using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venturi.Nicolas._4J.datadelgiorno.models
{
    class Data
    {
        private int _giorno;
        private int _mese;
        private int _anno;

        public int giorno
        {
            get
            {
                return _giorno;
            }
            set
            {
                _giorno = value;

            }
        }

        public int mese
        {
            get
            {
                return _mese;
            }
            set
            {
                _mese = value;


            }
        }

        public int anno
        {
            get
            {
                return _anno;
            }
            set
            {
                _anno = value;
            }
        }

        public Data(int g, int m, int a)
        {
            anno = a;
            giorno = g;
            mese = m;
        }

        public Data()
        {
            anno = 1900;
            giorno = 1;
            mese = 1;
        }

        public Data aggiungigiorni(int gagg, Data z)
        {
            int r = z.giorno;
            z.giorno += gagg;
            int f = (z.giorno % 31);
            if (z.giorno > 31)
            {
                
                z.mese += f;
                z.giorno = z.giorno-(31*f)-r ;


            }
            if (z.mese > 12)
            {
                z.anno += 1;
                z.mese = 1;
            }


            return z;
        }
        public Data togligiorni(int gtog, Data z)
        {
            z.giorno -= gtog;

            if (z.giorno < 1)
            {
                z.mese -= 1;
                z.giorno = z.giorno*-1;
            }
            if(z.giorno==0)
            {
                z.giorno = 31;
            }
            if (z.mese < 1)
            {
                z.anno -= 1;
                z.mese = 12;
            }
            return z;
        }

        public static string operator == (Data f,Data g )
            {
            if(f.giorno==g.giorno)
            {
                if(f.mese==g.mese)
                {
                    if(f.anno==g.anno)
                    {
                        return "le due dato sono uguali";
                    }
                }
            }

            return "le due date sono diverse";
            }

        public static string operator !=(Data f, Data g)
        {

            return "si";
        }

        public static string operator > (Data f, Data g)
        {
            if(f.anno > g.anno)
            {
                return "la prima data è posteriore all'altra";
            }
            else
            {
                if(f.anno == g.anno)
                {
                    if(f.mese > g.mese)
                    {
                        return "la prima data è posteriore all'altra";
                    }
                    else
                    {
                        if (f.mese == g.mese)
                        {
                            if (f.giorno > g.giorno)
                            {
                                return "la prima data è posteriore all'altra";
                            }
                            else
                            {
                                if (f.giorno == g.giorno)
                                {
                                    return "le due date sono uguali";
                                }
                                else
                                {
                                    return "la seconda data è posteriore alla prima";
                                }
                            }
                        }  
                        else
                        {
                            return "la seconda data è posteriore alla prima";
                        }
                    }
                }
                else
                {
                    return "la seconda data è posteriore alla prima";
                }
            }

        }

        public static string operator < (Data f, Data g)
        {
            return "";
        }

        public override string ToString()
        {

            return giorno+"/"+mese+"/"+anno;
        }


    }
}
