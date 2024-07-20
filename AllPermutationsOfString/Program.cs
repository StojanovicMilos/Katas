
char[] input = ['1', '2', '3', '4'];
//Generate all permutations of an given input array
Console.WriteLine(string.Join(",", Generator.GeneratePermutations(input)));
//Generate all combinations of an given input array
Console.WriteLine(string.Join(",", Generator.GenerateCombinations(input)));

class Generator
{
    public static string[] GeneratePermutations(char[] input)
    {
        string[] currentPermutations = [];
        foreach (var character in input)
        {
            currentPermutations = GeneratePermutationsByAdding(character, currentPermutations);
        }

        return currentPermutations.OrderBy(x => x).ToArray();
    }

    private static string[] GeneratePermutationsByAdding(char input, string[] currentPermutations)
        => currentPermutations.Any() ?
        currentPermutations.SelectMany(permutation =>
        {
            string[] newPermutations = new string[permutation.Length + 1];
            for (int i = 0; i < permutation.Length; i++)
            {
                newPermutations[i] = permutation.Substring(0, i) + input + permutation.Substring(i);
            }

            newPermutations[newPermutations.Length - 1] = permutation + input;
            return newPermutations;
        }).ToArray()
        : [input.ToString()];

    public static string[] GenerateCombinations(char[] input)
    {
        string[] currentCombinations = [""];
        foreach (var character in input)
        {
            currentCombinations = GenerateCombinationsByAdding(character, currentCombinations);
        }

        return currentCombinations.OrderBy(x => x).ToArray();
    }

    private static string[] GenerateCombinationsByAdding(char character, string[] currentCombinations) 
        => currentCombinations.SelectMany(combination => new string[] { combination, combination + character }).ToArray();
}