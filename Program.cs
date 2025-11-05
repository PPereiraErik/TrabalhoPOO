using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Tela tela = new Tela();
        AtendimentoCRUD atendimentoCRUD = new AtendimentoCRUD(tela);
        GerenciamentoCRUD gerenciamentoCRUD = new GerenciamentoCRUD(tela);
        RelatoriosCRUD relatoriosCRUD = new RelatoriosCRUD(tela);

        string opcao = "";
        List<string> opcoes = new List<string>
        {
            "1 - Atendimento",
            "2 - Gerenciamento",
            "3 - Relatórios",
            "0 - Sair"
        };

        while (true)
        {
            tela.LimparTela();
            tela.MostrarMenu("MENU PRINCIPAL", opcoes);
            opcao = Console.ReadLine();

            if (opcao == "0") break;
            else if (opcao == "1") atendimentoCRUD.ExecutarCRUD();
            else if (opcao == "2") gerenciamentoCRUD.ExecutarCRUD();
            else if (opcao == "3") relatoriosCRUD.ExecutarCRUD();
            else
            {
                tela.MostrarMensagem("Opção inválida. Pressione uma tecla...");
                Console.ReadKey();
            }
        }
    }
}
