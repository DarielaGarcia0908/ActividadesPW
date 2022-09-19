namespace Unidad1_Actividad2.Models
{
    public class CalificacionViewModel
    {

        public float Calif1 { get; set; }
        public float Calif2 { get; set; }
        public float Calif3 { get; set; }

        public float Promedio { get { return (Calif1 + Calif2 + Calif3) / 3; } }

        public string Estado()
        {
            
            if (Promedio >= 70)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }
    }
}
