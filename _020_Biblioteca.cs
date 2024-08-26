using System;
using System.Collections.Generic; // Necessário para usar List<T>

namespace CursoCSharp
{
    class Biblioteca
    {
        private List<Livro> acervo = new List<Livro>();

        // Método para adicionar livro
        public void AddLivro(Livro l)
        {
            acervo.Add(l);
        }

        // Método para remover livro
        public void RemoverLivro(Livro l)
        {
            if (acervo.Contains(l))
            {
                acervo.Remove(l);
            }
        }

    }
}
