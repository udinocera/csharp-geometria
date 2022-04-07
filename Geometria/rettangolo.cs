using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometria
{
    public class Rettangolo
    {
        public int baseRettangolo;
        public int altezzaRettangolo;

        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }
        // PERIMETRO RETTANGOLO
        public int Perimetro(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
            int perimetoRettangolo = 2 * (baseRettangolo + altezzaRettangolo);
            return perimetoRettangolo;

        }

        // AREA RETTANGOLO
        public int Area(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
            int areaRettangolo = baseRettangolo * altezzaRettangolo;
            return areaRettangolo;
        }
    }

    public class RettangoloSecondo
    {
        public int BaseRettangoloSecondo;
        public int AltezzaRettangoloSecondo;

        public RettangoloSecondo(int BaseRettangoloSecondo, int AltezzaRettangoloSecondo)
        {
            this.BaseRettangoloSecondo = BaseRettangoloSecondo;
            this.AltezzaRettangoloSecondo = AltezzaRettangoloSecondo;
        }
        // PERIMETRO RETTANGOLO
        public int perimetroSecondo(int BaseRettangoloSecondo, int AltezzaRettangoloSecondo)
        {
            this.BaseRettangoloSecondo = BaseRettangoloSecondo;
            this.AltezzaRettangoloSecondo = AltezzaRettangoloSecondo;
            int PerimetroRettangoloSecondo = 2 * (BaseRettangoloSecondo + AltezzaRettangoloSecondo);
            return PerimetroRettangoloSecondo;

        }

        // AREA RETTANGOLO
        public int areaSecondo(int BaseRettangoloSecondo, int AltezzaRettangoloSecondo)
        {
            this.BaseRettangoloSecondo = BaseRettangoloSecondo;
            this.AltezzaRettangoloSecondo = AltezzaRettangoloSecondo;
            int AreaRettangoloSecondo = BaseRettangoloSecondo * AltezzaRettangoloSecondo;
            return AreaRettangoloSecondo;
        }
    }

}