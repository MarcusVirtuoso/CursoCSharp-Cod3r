using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Fundamentos - Primeiro Programa", PrimeiroPrograma.Executar},
                {"Fundamentos - Comentários", Comentarios.Executar},
                {"Fundamentos - Variáveis e Constantes", VariaveisEConstantes.Executar},
                {"Fundamentos - Inferência", Inferencia.Executar},
                {"Fundamentos - Interpolação", Interpolacao.Executar},
                {"Fundamentos - Notação Ponto", NotacaoPonto.Executar},
                {"Fundamentos - Lendo dados", LendoDados.Executar},
                {"Fundamentos - Formatando numero", FormatandoNumero.Executar},
                {"Fundamentos - Conversões", Conversoes.Executar},
                {"Fundamentos - Operadores Aritméticos", OperadoresAritmeticos.Executar},
                {"Fundamentos - Operadores relacionais", OperadoresRelacionais.Executar},
                {"Fundamentos - Operadores lógicos", OperadoresLogicos.Executar},
                {"Fundamentos - Operadores de atribuição", OperadoresAtribuicao.Executar},
                {"Fundamentos - Operadores Unários", OperadoresUnarios.Executar},
                {"Fundamentos - Operador Ternario\n", OperadorTernario.Executar},

                // Estruturas de Controle
                {"Estruturas de Controle - Estrutura IF", EstruturaIf.Executar},
                {"Estruturas de Controle - Estrutura IF / ELSE", EstruturaIfElse.Executar},
                {"Estruturas de Controle - Estrutura IF / ELSE IF", EstruturaIfElseIf.Executar},
                {"Estruturas de Controle - Estrutura SWITCH", EstruturaSwitch.Executar},
                {"Estruturas de Controle - Estrutura WHILE", EstruturaWhile.Executar},
                {"Estruturas de Controle - Estrutura DO WHILE", EstruturaDoWhile.Executar},
                {"Estruturas de Controle - Estrutura FOR", EstruturaFor.Executar},
                {"Estruturas de Controle - Estrutura FOR EACH", EstruturaForEach.Executar},
                {"Estruturas de Controle - Usando BREAK", UsandoBreak.Executar},
                {"Estruturas de Controle - Usando CONTINUE\n", UsandoContinue.Executar},

                // Classes e métodos
                {"Classes e métodos - Membros", Membros.Executar},
                {"Classes e métodos - Construtores", Construtores.Executar},
                {"Classes e métodos - Métodos com retorno", MetodosComRetorno.Executar},
                {"Classes e métodos - Métodos estáticos", MetodosEstaticos.Executar},
                {"Classes e métodos - Atributos estáticos", AtributosEstaticos.Executar},
                {"Classes e métodos - Desafio atributo", DesafioAtributo.Executar},
                {"Classes e métodos - Params", Params.Executar},
                {"Classes e métodos - Paramentos Nomeados", ParametrosNomeados.Executar},
                {"Classes e métodos - Getters and Setters", GetSet.Executar},
                {"Classes e métodos - Props", Props.Executar},
                {"Classes e métodos - Readonly", Readonly.Executar},
                {"Classes e métodos - Exemplo Enumerações (Enum)", ExemploEnum.Executar},
                {"Classes e métodos - Struct", ExemploStruct.Executar},
                {"Classes e métodos - Struct X Classe", StructVsClasse.Executar},
                {"Classes e métodos - Atribuição por valor ou por referencia", ValorVsReferencia.Executar},
                {"Classes e métodos - Parâmetros por referencia", ParametrosPorReferencia.Executar},
                {"Classes e métodos - Parâmetro com valor padrão\n", ParametroPadrao.Executar},

                // Coleções
                {"Coleções - Array", Colecoes.Array.Executar},
                {"Coleções - List", ColecoesList.Executar},
                {"Coleções - ArrayList", ColecoesArrayList.Executar},
                {"Coleções - Set", ColecoesSet.Executar},
                {"Coleções - Queue", ColecoesQueue.Executar},
                {"Coleções - Igualdade", Igualdade.Executar},
                {"Coleções - Stack", ColecoesStack.Executar},
                {"Coleções - Dictionay\n", ColecoesDictionary.Executar},

                // Orientação a objeto
                {"Orientação a Objeto - Heranca", Heranca.Executar},
                {"Orientação a Objeto - Construtor this", ConstrutorThis.Executar},
                {"Orientação a Objeto - Encapsulamento", OO.Encapsulamento.Executar},
                {"Orientação a Objeto - Polimorfismo", Polimorfismo.Executar},
                {"Orientação a Objeto - Abstract", Abstract.Executar},
                {"Orientação a Objeto - Interface", Interface.Executar},
                {"Orientação a Objeto - Sealed\n", Sealed.Executar},

                // Metodos e funções
                {"Métodos e funções - Exemplo Lambda", ExemploLambda.Executar},
                {"Métodos e funções - Lambdas como Delegates", LambdasDelegate.Executar},
                {"Métodos e funções - Usando delegates", UsandoDelegates.Executar},
                {"Métodos e funções - Delegate como função anônima", DelegateFuncAnonima.Executar},
                {"Métodos e funções - Delegate como parametros", DelegatesComoParametros.Executar},
                {"Métodos e funções - Métodos de extensão\n", MetodosDeExtensao.Executar},

                // Exceções 
                {"Exceções - Primeira Exceção", PrimeiraExcecao.Executar},
                {"Exceções - Exceções personalizadas\n", ExcecoesPersonalizadas.Executar},

                // API
                {"Usando API - Primeiro arquivo", PrimeiroArquivo.Executar},
                {"Usando API - Lendo arquivos", LendoArquivos.Executar},
                {"Usando API - Exemplo FileInfo", ExemploFileInfo.Executar},
                {"Usando API - Diretorios", Diretorios.Executar},
                {"Usando API - Exemplo DirectoryInfo", ExemploDirectoryInfo.Executar},
                {"Usando API - Exemplo Path", ExemploPath.Executar},
                {"Usando API - Exemplo DateTime", ExemploDateTime.Executar},
                {"Usando API - Exemplo TimeSpan\n", ExemploTimeSpan.Executar},
                
                // Topicos avançados
                {"Tópicos avançados - LINQ 01", LINQ1.Executar},
                {"Tópicos avançados - LINQ 02", LINQ2.Executar},
                {"Tópicos avançados - Nullables", Nullables.Executar},
                {"Tópicos avançados - Dynamics", Dynamics.Executar},
                {"Tópicos avançados - Genericos", Genericos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}