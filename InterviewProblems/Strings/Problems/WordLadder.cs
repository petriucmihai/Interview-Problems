using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems.Strings.Problems
{
    class WordLadder
    {
        /*
        Given two words (beginWord and endWord), and a dictionary's word list, find the length of shortest transformation sequence from beginWord to endWord, such that:

        Only one letter can be changed at a time.
        Each transformed word must exist in the word list. Note that beginWord is not a transformed word.
        Note:

        Return 0 if there is no such transformation sequence.
        All words have the same length.
        All words contain only lowercase alphabetic characters.
        You may assume no duplicates in the word list.
        You may assume beginWord and endWord are non-empty and are not the same.
        Example 1:

        Input:
        beginWord = "hit",
        endWord = "cog",
        wordList = ["hot","dot","dog","lot","log","cog"]

        Output: 5

        Explanation: As one shortest transformation is "hit" -> "hot" -> "dot" -> "dog" -> "cog",
        return its length 5.
        Example 2:

        Input:
        beginWord = "hit"
        endWord = "cog"
        wordList = ["hot","dot","dog","lot","log"]

        Output: 0

        Explanation: The endWord "cog" is not in wordList, therefore no possible transformation.
        */

        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (!wordList.Contains(endWord) || beginWord == null || endWord == null)
            {
                return 0;
            }

            HashSet<string> wordDict = new HashSet<string>();
            foreach (string word in wordList)
            {
                wordDict.Add(word);
            }

            Queue<string> queue = new Queue<string>();
            queue.Enqueue(beginWord);

            HashSet<string> visited = new HashSet<string>();
            visited.Add(beginWord);

            int level = 1;
            int queueSize = queue.Count();

            while (queue.Count() > 0)
            {
                string word = queue.Dequeue();
                queueSize--;

                if (word != null)
                {

                    for (int i = 0; i < word.Length; i++)
                    {
                        char[] chars = word.ToCharArray();
                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            chars[i] = c;

                            string newWord = new string(chars);

                            if (newWord == endWord)
                            {
                                return level + 1;
                            }
                            if (wordList.Contains(newWord) && !visited.Contains(newWord))
                            {
                                queue.Enqueue(newWord);
                                visited.Add(newWord);
                            }
                        }
                    }

                }
                // No word 1 letter away, try 2 letters away, etc. Do this only when each option is exhausted
                if (queueSize == 0)
                {
                    queueSize = queue.Count();
                    level++;
                }
            }

            return 0;
        }
    }
}
