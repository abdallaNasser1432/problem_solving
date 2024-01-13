public class Solution {
    public bool HalvesAreAlike(string name)
{
    string vowels = "aioeu";
    string a = name.Substring(0, name.Length / 2);
    string b = name.Substring(name.Length / 2, name.Length / 2);
    return a.Count(c => vowels.Contains(c, StringComparison.OrdinalIgnoreCase))
        == b.Count(c => vowels.Contains(c, StringComparison.OrdinalIgnoreCase));
}
        
}