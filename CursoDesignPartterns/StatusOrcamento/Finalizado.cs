using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPartterns.StatusOrcamento
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos finalizados não recebem desconto extra");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamentos não podem ir para estado de Aprovado, pois já está Finalizados");
        }

        public void Andamento(Orcamento orcamento)
        {
            throw new Exception("Orcamentos não podem ir para estado de Em Andamento, pois já está reprovado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamentos não podem ir para estado de Aprovado, pois já está Finalizados");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamentos já está em modo Reprovado");
        }
    }
}
