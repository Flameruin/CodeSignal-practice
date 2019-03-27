/*
For sequence = [1, 3, 3, 3, 1], the output should be
arrayMode(sequence) = 3
For sequence = [1, 3, 2, 1], the output should be
arrayMode(sequence) = 1
*/


dynamic arrayMode(int[] sequence) {
            Dictionary<dynamic, int> reapets = new Dictionary<dynamic, int>();
            foreach(var n in sequence)
            {
                if(reapets.ContainsKey(n))
                    reapets[n]++;
                else
                    reapets.Add(n,1);
            }
            int maxMode = reapets.Values.Max();
            foreach(KeyValuePair<dynamic, int> entry in reapets)
            {
                if (entry.Value == maxMode)
                    return entry.Key;
            }
    return -1;
}
