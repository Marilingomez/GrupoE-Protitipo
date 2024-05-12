using Newtonsoft.Json;

namespace GrupoE_Protitipos.Entidades.Deposito.ArchivoDeposito
{
    public static class ArchivoDeposito
    {
        private static List<Deposito> depositos;

        private static string path = @"../../../InfoPrecargada/depositos.json";

        static ArchivoDeposito()
        {
            if (File.Exists(path))
            {
                var contenido = File.ReadAllText(path);
                depositos = JsonConvert.DeserializeObject<List<Deposito>>(contenido);
            }
            else
            {
                depositos = new List<Deposito>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(depositos);
            File.WriteAllText(path, contenido);
        }

        public static List<Deposito> ObtenerDepositos()
        {
            return depositos;
        }
    }
}
