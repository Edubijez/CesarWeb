namespace CesarWeb.Services
{

    public class SeguridadService : ISeguridadService<int>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");

        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, int clave)
        {

             clave=clave*(-1);
            char[] comparacion=new char[Mensaje.Length];

            for(int k = 0 ; k < Mensaje.Length ; k++){
                comparacion[k] = Mensaje[k];
            }

            for(int i = 0 ; i< Mensaje.Length ; i++){
                for(int j = 0 ; j <= 26 ; j++){
                    if(Mensaje[i] == ABECEDARIO[j]){
                        comparacion[i] = ABECEDARIO[j - clave];
                    }
                }
            }
            string resultado=new string(comparacion);
            Mensaje=resultado;

            return Mensaje;
        }

        
        
        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, int clave)
        {

            char[] comparando=new char[Mensaje.Length];

            for(int k = 0 ; k < Mensaje.Length ; k++){
                comparando[k] = Mensaje[k];
            }

            for(int i = 0 ; i < Mensaje.Length ; i++){
                for(int j = 0 ; j <= 26 ; j++){
                    if(Mensaje[i] == ABECEDARIO[j]){
                        comparando[i] = ABECEDARIO[j + clave];
                    }
                }
            }
            string total=new string(comparando);
            Mensaje=total;

            return Mensaje;
        }
    }


}