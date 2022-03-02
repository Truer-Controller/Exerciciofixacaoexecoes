using System;
using System.Collections.Generic;
using System.Text;

namespace Exerciciofixacaoexecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string massage) : base(massage)
        {
        }
    }
}
