using System;

namespace Aula15TryCatch
{
    public class Permissao
    {
        public bool Permitir { get; set; }

        public void Autorizar(){

            Console.WriteLine("Deseja permitir acesso? Digite true ou false");  

            try{
                Permitir = Boolean.Parse( Console.ReadLine() );
                if (Permitir == false){
                    Console.WriteLine("OK então.");
                    System.Environment.Exit(0);
                }
            }
            catch(Exception){                
                Console.WriteLine("Erro na aplicação: dados inválidos");
                System.Environment.Exit(0);
            }


        }
    }
}