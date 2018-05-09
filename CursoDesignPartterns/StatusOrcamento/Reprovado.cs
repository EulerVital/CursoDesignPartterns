using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPartterns.StatusOrcamento
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados não recebem desconto extra");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamentos já está em modo Reprovado");
        }

        public void Andamento(Orcamento orcamento)
        {
            throw new Exception("Orcamentos não podem ir para estado de Em Andamento, pois já está reprovado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamentos não podem ir para estado de Aprovado, pois já está reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
