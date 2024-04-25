using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosT6
{
    internal class Contato
    {
        //Declaração de variaveis.
        private string _id;
        private string sobrenome;
        private string telefone;

        //Propiedades. São os métodos "get" e "set"
        //get = leitura
        //set = definição
        //é posssivel ser somente leitura, ou somente definição...
        public string Nome
        {
            get
            {
                return Nome;

            }
            set
            {
                Nome = value;
            }

        }
        public string Sobrenome
        {
            get
            {
                return Sobrenome;

            }
            set
            {
                sobrenome = value;
            }
        { set}
          public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value, Length == 13)

         {
                    telefone = value;
                }
             else
                {
                    telefone = "(00) 00000-0000";
                }
            }
            public Contato ()
           {
            Nome = "Cláudio";
            Sobrenome 
           }

        }
    }
}
