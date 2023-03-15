using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302210025
{
    public enum posisi { berdiri, terbang, jongkok, tengkurap }
    public enum triger { tombolW, tombolS, tombolX }
    internal class PosisiKarakterGame
    {
        class moveState
        {

            public posisi curr, next;
            public triger tombol;
            public moveState(posisi curr, posisi next, triger tombol)
            {
                this.curr = curr;
                this.next = next;
                this.tombol = tombol;
            }
        }
        posisi mycurr = posisi.berdiri;
        triger mytriger;
        moveState[] move = 
        {
       new moveState(posisi.berdiri,
                               posisi.terbang,
                               triger.tombolW),
        new moveState(posisi.terbang,
                                   posisi.jongkok,
                                   triger.tombolX),
           new moveState(posisi.jongkok,
                                   posisi.tengkurap,
                                   triger.tombolS),
           new moveState(posisi.tengkurap,
                                   posisi.jongkok,
                                   triger.tombolW),
           new moveState(posisi.jongkok,
                                   posisi.berdiri,
                                   triger.tombolW),
           new moveState(posisi.berdiri,
                                   posisi.jongkok,
                                   triger.tombolS),
           new moveState(posisi.terbang,
                                   posisi.berdiri,
                                   triger.tombolS)
        };
        public PosisiKarakterGame()
        {
            Console.WriteLine("Posisi Sekarang " + mycurr.ToString() + ", posisi stand by");  
        }
        public void setMyTriger(triger t)
        {
            mytriger = t;
            getMyPosition();
        }
        public void getMyPosition()
        {
            for(var i = 0; i < move.Length; i++)
            {
               moveState tmp = move[i];
               if(tmp.tombol == mytriger &&tmp.curr == mycurr)
                {
                    if(tmp.next.ToString() == "berdiri")
                    {
                        Console.WriteLine("posisi stand by");
                    }else if(tmp.next.ToString() == "tengkurap")
                    {
                        Console.WriteLine("posisi istiarahat");
                    }
                    else
                    {
                        Console.WriteLine("Move, current position : " + tmp.next.ToString());
                    }
                    mycurr= tmp.next;
                }
            }
        }

       
        //add all state
       
     }
}
