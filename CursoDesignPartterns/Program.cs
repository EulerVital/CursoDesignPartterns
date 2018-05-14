using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPartterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strategy
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.00);
            CalculadorDeImposto calculador = new CalculadorDeImposto();
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);
            Console.ReadKey();

            //Chain of Responsibility
            CalculadorDeDesconto calclulador = new CalculadorDeDesconto();
            orcamento = new Orcamento(500);
            orcamento.AdicionarItem(new Item("Caneta", 250));
            orcamento.AdicionarItem(new Item("Lapis", 250));
            double desconto = calclulador.Calcula(orcamento);
            Console.WriteLine(desconto);
            Console.ReadKey();

            //Template Method
            orcamento = new Orcamento(500);
            TempleteDeImpostoCondicional ickv = new IKCV();
            TempleteDeImpostoCondicional icpp = new ICPP();
            string valor = ickv.DeveUsarMaximaTaxacao(orcamento) ? "Sim IKCV" : "Não IKCV";
            Console.WriteLine(valor);
            valor = icpp.DeveUsarMaximaTaxacao(orcamento) ? "Sim ICPP" : "Não ICPP";
            Console.WriteLine(valor);
            Console.ReadKey();

            //Decorator
            iss = new ISS(new ICMS());
            double valorDecora = iss.Calcula(orcamento);
            Console.WriteLine(valorDecora);
            Console.ReadKey();

            //State
            Orcamento reforma = new Orcamento(500);
            Console.WriteLine(reforma.Valor);
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);
            reforma.Aprova();
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);
            reforma.Finaliza();
            Console.ReadKey();

            //Builder
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            //Fluent interface ou Method chaining
            criador
                .ParaEmpresa("Sodit - Solutions on Demand")
                .ComCnpj("23.645.984/0001-32")
                .ComItem(new ItemDaNota("item 1", 19.90))
                .ComItem(new ItemDaNota("item 2", 39.90))
                .ComItem(new ItemDaNota("item 3", 29.90))
                .NaDataAtual()
                .ComObservacao("uma obs qualquer");

            //Observer
            //Ajuda a desacoplar o codigo
            criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new NotaFiscalDao());
            criador.AdicionaAcao(new EnviadorDeSms());

            NotaFiscal nf = criador.Constroi();
            Console.ReadKey();
        }
    }
}

