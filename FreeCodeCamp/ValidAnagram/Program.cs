//https://www.youtube.com/watch?v=Peq4GCPNC5c&t=37s

Console.WriteLine(ValidAnagram("nameless", "salesmen"));

bool ValidAnagram(string s1, string s2)
{
    if(s1 == s2)
    {
        return true;
    }

    if(s1.Length != s2.Length)
    {
        return false;
    }

    var characters1 = MapToDictionary(s1);
    var characters2 = MapToDictionary(s2);
    if(characters1.Keys.Count != characters2.Keys.Count)
    {
        return false;
    }

    foreach (var (key, value) in characters1)
    {
        if(!characters2.ContainsKey(key) || characters2[key] != value)
        {
            return false;
        }
    }

    return true;
}

Dictionary<char, int> MapToDictionary(string s)
{
    var dictionary = new Dictionary<char, int>();

    foreach (var character in s)
    {
        if (dictionary.ContainsKey(character))
        {
            dictionary[character]++;
        }
        else dictionary[character] = 1;
    }

    return dictionary;
}