using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPartterns.StatusOrcamento
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.002;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamentos já está em modo de Aprovação.");
        }

        public void Andamento(Orcamento orcamento)
        {
            throw new Exception("Orcamentos não podem ir para estado de Em Andamento, pois já está aprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamentos não podem ir para estado de Reprovado, pois já está aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
