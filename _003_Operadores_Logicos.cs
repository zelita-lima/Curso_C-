using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class _003_Operadores_Logicos
    {
        // metodo que demonstra o operador e logicos(&&)
        public static bool ELogico(bool a, bool b)
        {
            return a && b;
        }

        // metodo que demonstra o operador OU logicos(||)
        public static bool OULogico(bool a, bool b)
        {
            return a || b;
        }

        // metodo que demonstra o operador negação(!)
        public static bool Negacao(bool a)
        {
            return !a;
        }

        // metodo que demonstra o operador o exclusive(^)
        public static bool OUExclusive(bool a, bool b)
        {
            return a ^ b;
        }
    }
}
