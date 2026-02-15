using ExerciciosCSharp.CodeWars;
using ExerciciosCSharp.Exercicios;
using ExerciciosCSharp.IfElse;
using ExerciciosCSharp.LeetCode;
using ExerciciosCSharp.Matriz;
using ExerciciosCSharp.StringBuilderSB.Easy;

namespace Program;
class Program
{
    static void Main(string[] args)
    {
        var central = new CentralDeExercicios(new Dictionary<string, Action>()
        {
            { $"{nameof(MenuComTresOpcoesDeSoma)}", MenuComTresOpcoesDeSoma.Executar },
            { $"Iguais e Diferentes", IguaisEDiferentes.Executar },
            { $"Reajuste Salarial", ReajusteSalarial.Executar },
            { $"Matriz", Matriz.Executar },
            { $"Receber 15 valores", Receber15Valores.Executar },
        
            //If Else
            { $"Número negativo ou não", NegativoOuNao.Executar },
            { $"Número par ou impar", ImparPar.Executar },
        
            //Matriz
            { $"Percorrer Matriz", PercorrerMatriz.Executar },
        
            //Code Wars
            { $"ArrayDiff", ArrayDiff.Executar },
            { $"Disemvowel", Disemvowel.Executar },
            { $"Accum", Accum.Executar },
            { $"BuildTower", BuildTower.Executar },
            { $"Replace With Alphabet Position", ReplaceWithAlphabetPosition.Executar },
            { $"Are they the \"same\"?", ReplaceWithAlphabetPosition.Executar },
            { $"IP Validation", IPValidation.Executar },
        
            //StringBuilder
            { $"ReverseWord", ReverseWordsStringBuilder.Executar },
            { $"{nameof(FruitsList)}", FruitsList.Executar },

            //LeetCode
            { $"{nameof(PalindromeNumber)}", PalindromeNumber.Executar }
        });

        central.SelecionarEExecutar();
    }
}