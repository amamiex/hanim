﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrjHikariwoAnim
{
    /// <summary>
    /// TimeLine全体の管理
    /// TIMELINE<FRAME>
    /// FRAME<ELEMENTS> データ削減の為パラメータ変化のあるフレームのみの記録
    /// ELEMENTS<ATRIBUTEbase>
    /// </summary>
    [Serializable]
    public class TIMELINEbase
    {
        //Frameの増減やコピー削除
        //Frame間補完 Completion(補完) Interpolation(次元補完)
        // Linear Cube Lerp ...
        //Completion(Frame A,Frame B,CompletionTYPE T)
        //Frame[] Divid(Frame A,Frame B,int DividNum

        //現在編集中のステージ上フレーム(独立オブジェクト)
        //
        public FRAME EditFrame;
        public string Name;//Project Name

        private int mCurrentIndex;//

        public List<FRAME> gmTimeLine;

        //init
        public TIMELINEbase()
        {
            EditFrame = new FRAME();
            gmTimeLine = new List<FRAME>();
            gmTimeLine.Add(EditFrame);
            Top();
        }

        //フレーム移動系
        public void Top() { ToIndex(0); }
        public void PrevKey() { ToIndex(mCurrentIndex-1); }
        public void NextKey() { ToIndex(mCurrentIndex+1); }
        public void End() { ToIndex(gmTimeLine.Count); }
        /// <summary>
        /// インデックスでのフレーム移動
        /// </summary>
        /// <param name="x"></param>
        public void ToIndex(int x)
        {
            if (gmTimeLine == null) return;
            if (gmTimeLine.Count == 0) return;
            if (x < 0) return;
            if (x > gmTimeLine.Count) return;
            //Now -> Store
            //CurrentFrame -> EditFrame 
            EditFrame =new FRAME(gmTimeLine[x]);
            mCurrentIndex = x;
        }
        /// <summary>
        /// フレーム指定での移動　実フレームが存在しない時はFalse
        /// </summary>
        /// <param name="FrameNum">目的のフレーム番号</param>
        /// <returns>指定のフレームは存在しない</returns>
        public bool ToFrame(int FrameNum)
        {
            int? pos=FindIndex(FrameNum);
            if (pos == null) { return false; }// Not Found
            ToIndex((int)pos);
            return true;
        }
        /// <summary>
        /// 現在のフレームをリストに戻す
        /// </summary>
        public void StoreNowFrame()
        {
            gmTimeLine[mCurrentIndex] = EditFrame;
        }
        /// <summary>
        /// フレームオブジェクトを追加(同フレームは上書き)
        /// カレントフレームを移動する
        /// </summary>
        /// <param name="f"></param>
        public void AddFrame(FRAME f)
        {
            //FrameIndexを確認
            int? res = FindIndex(f.FrameNum);
            //同じフレームは上書きする
            if (res != null)
            {
                //上書き
                gmTimeLine[(int)res] = f;
                mCurrentIndex = (int)res;
            }
            else
            {
                //新規 該当フレームの挿入場所を探す
                //もしくは追加してからFlameNumで昇順ソートする？
                //0< f.FlameNum <Max(Last)
                int pos = FindPosition(f.FrameNum);
                if (pos+1 >= gmTimeLine.Count)
                {
                    //未発見 最後尾追加
                    gmTimeLine.Add(f);
                    mCurrentIndex = gmTimeLine.Count-1;
                }
                else
                {
                    //pos直前に追加
                    gmTimeLine.Insert((int)pos+1,f);
                    mCurrentIndex = pos + 1;
                }
            }
        }
        //現在編集中のフレームを戻す
        //NowFrameに変更等加える操作の最後には呼ぶように!
        public void Store() { gmTimeLine[mCurrentIndex] = EditFrame; }
        /// <summary>
        /// Index直前に挿入
        /// </summary>
        /// <param name="index"></param>
        /// <param name="f"></param>
        public void Insert(int index, FRAME f)
        {
            //現在のフレームを戻す
            //Store();
            gmTimeLine[mCurrentIndex] = EditFrame;
            gmTimeLine.Insert(index, f);
        }
        public void RemoveFrameNum(int FrameNum)
        {
            //リストから該当フレームがみつかれば削除する(先頭一致)
            int? ret = FindIndex(FrameNum);
            if(ret !=null)
            {
                gmTimeLine.RemoveAt((int)ret);
            }
        }
        public void RemoveIndex(int Index) { gmTimeLine.RemoveAt(Index); }
        /// <summary>
        /// 全体から目的のフレーム番号を含むインデックスを返す
        /// 未発見はnull
        /// </summary>
        /// <param name="FrameNum">目的のフレーム数</param>
        /// <returns>null:nothing</returns>
        public int? FindIndex(int FrameNum)
        {
            int? ret=null;
            for(int cnt=0;cnt<gmTimeLine.Count;cnt++)
            {
                if(gmTimeLine[cnt].FrameNum == FrameNum)
                {
                    ret = cnt;
                    continue;
                }
            }
            return ret;
        }

        public FRAME GetFrame(int FrameNum)
        {
            int? idx = FindIndex(FrameNum);
            if (idx == null) return null;
            return gmTimeLine[(int)idx];
        }
        /// <summary>
        /// FrameNumのあるIndexを前方から探す
        /// </summary>
        /// <param name="FrameNum"></param>
        /// <returns>不在=規定値0</returns>
        public int FindPosition(int FrameNum)
        {
            //0 < Prev < Frame <Next < MAXになる場所を前方から探す
            int prev = 0;//最小
            int max = gmTimeLine.Count();
            for(int cnt =0;cnt<max ;cnt++)
            {
                if(gmTimeLine[cnt].FrameNum<FrameNum)
                {
                    prev = cnt;
                }
            }
            return prev;             
        }
        public void Clear() { gmTimeLine.Clear(); }
        public void Remove(int Frame, uint Count)
        {
            //指定フレームからの範囲を削除
            int pos = 0;
            for (int cnt = pos;cnt<Count;cnt++)
            {
                pos = FindPosition(Frame+cnt);
                if(pos !=0 )
                {
                    gmTimeLine.RemoveAt(pos);
                }
            }
            //最終pos位置から最後までのFrameNumをCount数減算
            for(int cnt=pos;cnt<gmTimeLine.Count;cnt++)
            {
                if ((gmTimeLine[cnt].FrameNum - Count) >= 0)
                {
                    gmTimeLine[cnt].FrameNum -= (int)Count;
                }
            }
        }
        public void Insert(int Frame, int Count)
        {
            //指定以降の既存フレーム番号に+Countを追加
            //Frame以降のフレームを加算
            int pos = FindPosition(Frame);
            for (int cnt = pos; cnt < gmTimeLine.Count; cnt++)
            {
                if ((gmTimeLine[cnt].FrameNum + Count) >= 0)
                {
                    gmTimeLine[cnt].FrameNum += (int)Count;
                }
            }
        }

        //SaveLoad Undo/Redo にも転用
        public void SaveToFile(string  fullPath)
        {
            FileStream fs = new FileStream(fullPath, FileMode.Create);
            SaveToStream(fs);
            fs.Close();
        }
        public void SaveToStream(Stream stm)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(TIMELINEbase));
            serializer.WriteObject(stm, this);
        }
        public void LoadFromFile(string fullPath)
        {
            FileStream fs = new FileStream(fullPath, FileMode.Open);
            LoadFromStream(fs);
            fs.Close();
        }
        public void LoadFromStream(Stream stm)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(TIMELINEbase));
            TIMELINEbase tl = (TIMELINEbase) serializer.ReadObject(stm);
        }

        //操作系関数

        /// <summary>
        /// Frameから前後を検出しフレーム補完したものを返す
        /// </summary>
        /// <param name="FrameNum"></param>
        public FRAME Completion(int FrameNum)
        {
            //A Bがないと補完しようがないのでCount=0時はそのまま null
            if (gmTimeLine.Count <= 1) return null;

            int? frm_a = FindPosition(FrameNum);
            int? frm_b;

            FRAME ret=null;

            if (frm_a != null)
            {
                //最後尾チェック
                if(frm_a != gmTimeLine.Count - 1)
                {
                    frm_b = frm_a + 1;


                }else
                {//終端だとどうすべ・・ 
                }
            }
            else
            { //前フレーム不明　0を基準にする
                frm_a = 0;
                frm_b = 1;                
            }

            return ret;
        }
        /// <summary>
        /// フレームLinear補完
        /// </summary>
        /// <param name="rate">重み</param>
        /// <param name="Index1">対象1</param>
        /// <param name="Index2">対象2</param>
        /// <returns></returns>
        public FRAME FrameCompLinier(int Index1,int Index2,float rate)
        {
            //座標差分を取る？
            FRAME ret = gmTimeLine[Index1].Clone();
            for (int cnt = 0; cnt < gmTimeLine[Index1].ElementsCount; cnt++)
            {
                ELEMENTS ele1 = gmTimeLine[Index1].GetElement(cnt);
                ELEMENTS ele2 = gmTimeLine[Index2].GetElement(cnt);
                ELEMENTS rest = ret.GetElement(cnt);
                rest.Atr.Position = Vector3.Linear(ele1.Atr.Position, ele2.Atr.Position, rate);

            }
            return ret;
        }
        public FRAME FrameCompLerp(int Index1,int Index2,float rate)
        {
            return new FRAME();
        }

    }

    /// <summary>
    /// 1フレーム中に利用されるエレメントリストの管理
    /// </summary>
    [Serializable]
    public class FRAME
    {
        //Frame:ELEMENTSの塊
        List<ELEMENTS> mFrame;//部品格納リスト
        public int ActiveIndex;
        
        public string Text;//フレーム毎に設定したいコマンドやコメント等
        public enum TYPE {KeyFrame,Control }
        public TYPE Type;//Type Role
        public int FrameNum;//自身のフレーム番号(配列indexとは一致しない事に注意)
        

        //init
        public FRAME()
        {
            mFrame = new List<ELEMENTS>();
        }
        public FRAME(FRAME f)
        {
            mFrame = new List<ELEMENTS>();
            ActiveIndex = f.ActiveIndex;
            Text = f.Text;
            Type = f.Type;
            FrameNum = f.FrameNum;
            //FrameCopy
            for(int cnt=0;cnt<f.ElementsCount;cnt++)
            {
                mFrame.Add(f.mFrame[cnt]);
            }
        }
        //Clone
        public FRAME Clone()
        {
            //参照以外のコピー
            FRAME f = new FRAME();
            //必要な参照を個別でコピーする
            for(int cnt=0;cnt<this.mFrame.Count;cnt++)
            {
                f.mFrame.Add( this.mFrame[cnt].Clone());
            }
            //f.mFrame = this.mFrame.ToList();
            return f;
        }
        //SaveLoad
        public void SaveToFile(string fullPath)
        {
            FileStream stm = new FileStream(fullPath,FileMode.Create);
            SaveToStream(stm);
            stm.Close();
        }
        public void SaveToStream(Stream stm)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(FRAME));
            serializer.WriteObject(stm, this);
        }
        public void LoadFromFile(string fullPath)
        {
            FileStream stm = new FileStream(fullPath, FileMode.Open);
            LoadFromStream(stm);
            stm.Close();

        }
        public void LoadFromStream(Stream stm)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(FRAME));
            FRAME a = (FRAME)serializer.ReadObject(stm);
        }
        public string ToJson()
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(FRAME));
            MemoryStream ms = new MemoryStream();
            serializer.WriteObject(ms, this);
            return Encoding.UTF8.GetString(ms.ToArray());
        }
        public string ToXML()
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(FRAME));
            MemoryStream ms = new MemoryStream();
            serializer.WriteObject(ms, this);
            return Encoding.UTF8.GetString(ms.ToArray());
        }

        public int ElementsCount { get{return mFrame.Count(); } }
        public ELEMENTS GetElement(int index)
        {
            if (mFrame == null) return null;
            if (index < 0) return null;
            if (index > mFrame.Count) return null;
            return mFrame[index];
        }
        public ELEMENTS GetElementsFromName(string name)
        {
            ELEMENTS ret = mFrame.Find( (ELEMENTS e )=> e.Name ==name);
            return ret;
        }
        public ELEMENTS GetElementsFromHash(int hash)
        {
            ELEMENTS ret = mFrame.Find((ELEMENTS e) => e.GetHashCode() == hash);
            return ret;
        }
        public void RenameElements(object hash,string newName)
        {
            if (hash == null) return;
            int? hashB = (int)hash;

            ELEMENTS ret = mFrame.Find((ELEMENTS e) => e.GetHashCode() == hashB);
            ret.Name = newName;
        }
        /// <summary>
        /// NouFrame内のx,y座標にあるアイテム番号を取得しSelectをTrueにする
        /// 奥から探して最後に見つかった物(手前にあるもの)をセレクト
        /// </summary>
        /// <param name="x">X座標</param>
        /// <param name="y">Y座標</param>
        /// <param name="parent">親も同時にマーク</param>
        /// <returns>Index(False:null)</returns>
        public int? SelectElement(int x, int y, bool parent)
        {
            //奥から探して最後に見つかった物(手前にあるもの)をセレクト
            int? ret = null;
            for (int cnt =0; cnt < mFrame.Count; cnt++)
            {
                if(mFrame[cnt].Atr.IsHit(x, y))
                {
                    //Hits
                    ret = cnt;
                }
                else { mFrame[cnt].Select = false; }
            }
            if(ret !=null)
            {
                mFrame[(int)ret].Select = true;
            }
            return ret;
        }
        /// <summary>
        /// タグでエレメントを検索する
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="multi"></param>
        /// <returns></returns>
        public int? SelectElement(object tag,bool multi=false)
        {
            if (tag == null) return null;
            int? has = Convert.ToInt32(tag.ToString());

            //奥から探して最後に見つかった物(手前にあるもの)をセレクト
            int? ret = null;
            for (int cnt = 0; cnt < mFrame.Count; cnt++)
            {
                if (mFrame[cnt].Tag.Equals(tag))
                {
                    //Hits
                    ret = cnt;
                }
                else
                {
                    if (!multi)
                    {
                        mFrame[cnt].Select = false;
                    }

                }
            }
            if (ret != null)
            {
                mFrame[(int)ret].Select = true;
            }
            return ret;

        }
        public bool SetElements(int index,ELEMENTS e)
        {
            if (mFrame == null) return false;
            if (index < 0) return false;
            if (index > mFrame.Count) return false;
            mFrame[index] = e;
            return true;
        }
        public void AddElementsFromCEll(CELL work,int x , int y)
        {
            //アイテムの登録
            ELEMENTS elem = new ELEMENTS();
            elem.Atr = new AttributeBase();
            elem.Atr.CellID = work.GetHashCode();
            elem.Atr.Width = work.Img.Width;
            elem.Atr.Height = work.Img.Height;

            //画像サイズ半分シフトして画像中心をセンターに
            x -= elem.Atr.Width / 2;
            y -= elem.Atr.Height / 2;

            elem.Atr.Position = new Vector3(x, y, 0);

        }
        public void AddElements(ELEMENTS e)
        {
            mFrame.Add(e);
        }
        public void Remove(ELEMENTS e) { }


        /// <summary>
        /// 全体フィット表示する為に全ての部品が収まるサイズを返す
        /// </summary>
        /// <returns></returns>
        public Rectangle GetRectAll()
        {
            Rectangle retRect = new Rectangle();
            for(int cnt=0;cnt<mFrame.Count;cnt++)
            {
                //親子関係考慮にいれてない版
                AttributeBase a;
                a = mFrame[cnt].Atr;
                Size s=a.GetDrawSize();
                int x = (int)a.Position.X - s.Width  / 2;
                int y = (int)a.Position.Y - s.Height / 2;
                //SelectMinimun Left Top
                retRect.X = (retRect.X < x) ? retRect.X : x;
                retRect.Y = (retRect.Y < y) ? retRect.Y : y;
                //SelectMaxium Right Bottom
                x += s.Width;
                y += s.Height;
                retRect.Width  = (retRect.Width  < x) ? retRect.Width  : x;
                retRect.Height = (retRect.Height < y) ? retRect.Height : y;

            }
            return retRect;
        }
        
        public void MoveDown() { }

    }

    /// <summary>
    /// 部品１つの状態格納クラス
    /// AttributeBase Atr:メインになるプロパティ情報 
    /// </summary>
    [Serializable]
    public class ELEMENTS
    {
        public enum TYPE {Master,Child,Joint,Effec,Accessory,FX }
        TYPE Type;
        public bool Select;
        public string Name;
        public object Tag; //認識ID
        public int Value;
        public AttributeBase Atr;//継承のほうがいいのかなぁ・・
        public AttributeBase Parent;//未使用参照
        public AttributeBase[] Child;//未使用参照
        public AttributeBase Next;//未使用参照
        public AttributeBase Prev;//未使用参照

        public ELEMENTS()
        {
            Select = false;
            Atr = new AttributeBase();
        }
        public ELEMENTS(object tag,string name)
        {
            Select = false;
            Tag = tag;
            Name = name;
            Atr = new AttributeBase();
        }
        public ELEMENTS(ELEMENTS elm)
        {
            Select = false;
            Name = elm.Name;
            Tag = elm.Tag;
            Value = elm.Value;
            Atr = new AttributeBase(elm.Atr);
            Parent = elm.Parent;
            Child = elm.Child;
            Next = elm.Next;
            Prev = elm.Prev;              
        }
        public ELEMENTS Clone()
        {
            ELEMENTS retEle = new ELEMENTS();
            retEle.Atr = new AttributeBase(this.Atr);
            retEle.Tag = this.Tag;
            return retEle;
        }
        public string ToJson()
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ELEMENTS));
            MemoryStream ms = new MemoryStream();
            serializer.WriteObject(ms, this);
            return Encoding.UTF8.GetString(ms.ToArray());
        }
        public string ToXML()
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(ELEMENTS));
            MemoryStream ms = new MemoryStream();
            serializer.WriteObject(ms, this);
            return Encoding.UTF8.GetString(ms.ToArray());
        }
    }

}
