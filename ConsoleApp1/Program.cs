using ExerciciosCSharp.Exercicios;
using ExerciciosCSharp.IfElse;
using ExerciciosCSharp.Matriz;
using ExerciciosCSharp.CodeWars;
using ExerciciosCSharp.StringBuilderSB.Easy;

namespace Program
{

    class Program

    {

        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                { "1 - Menu com 3 opcoes de soma.", MenuComTresOpcoesDeSoma.Executar },
                { "2 - Iguais e Diferentes", IguaisEDiferentes.Executar },
                { "3 - Reajuste Salarial", ReajusteSalarial.Executar },
                { "4 - Matriz", Matriz.Executar },
                { "5 - Receber 15 valores", Receber15Valores.Executar },

                //If Else

                { "6 - Número negativo ou não", NegativoOuNao.Executar  },
                { "7 - Número par ou impar", ImparPar.Executar  },

                //Matriz
                { "8 - Percorrer Matriz", PercorrerMatriz.Executar  },

                //Code Wars
                { "9 - ArrayDiff", ArrayDiff.Executar },
                { "10 - Disemvowel", Disemvowel.Executar },
                { "11 - Accum", Accum.Executar },
                { "12 - BuildTower", BuildTower.Executar },
                { "13 - Replace With Alphabet Position", ReplaceWithAlphabetPosition.Executar },
                { "14 - Are they the \"same\"?", ReplaceWithAlphabetPosition.Executar },
                { "15 - IP Validation", IPValidation.Executar },

                //StringBuilder
                { "16 - ReverseWord", ReverseWordsStringBuilder.Executar },
                { "17 - FruitsList", FruitsList.Executar }



            }) ;

            central.SelecionarEExecutar();
        }
    }
}