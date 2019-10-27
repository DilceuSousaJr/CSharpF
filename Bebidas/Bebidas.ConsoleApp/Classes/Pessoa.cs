using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas.ConsoleApp.Classes
{
    class Pessoa
    {
        #region Propriedades 

        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        #endregion
        #region metodos
        public override string ToString()
        {
            return $"{Nome};{Sobrenome}";
        }
        #endregion
    }
}
