public class Solution {
    public IList<string> RemoveSubfolders(string[] folder) {

        Array.Sort(folder);
        List<string> list = new List<string>();
        int current = 0;
        list.Add(folder[current]);

        for(int i=1; i<folder.Length; i++)
        {
            if(!folder[i].StartsWith(folder[current]+'/'))
            {
                current = i;
                list.Add(folder[i]);
            }
        }
        return list;
    }
}