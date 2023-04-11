/*
 * Can you create a small C# terminal project that generates the number for Euro Million
 * Its 5 numbers from 1 to 50 and 2 stars from 1 to 12
 * The idea would be to create a program that randomly generates a key for this.
 */

namespace Euro_Millions
{
    public class LottoGenerator
    {

        /// <summary>
        /// Generate a hashset of normal and special values
        /// </summary>
        /// <returns></returns>
        public Tuple<HashSet<int>, HashSet<int>> GenerateRandomValues()
        {
            Random random = new();
            HashSet<int> normalNumbers = new();
            HashSet<int> specialNumbers = new();
            normalNumbers.Clear();
            specialNumbers.Clear();

            while (normalNumbers.Count < 5) // generate 5 unique random numbers
            {
                int randomNumber = random.Next(1, 50); // generate a random number between 1 and 100
                if (!normalNumbers.Contains(randomNumber)) // check if the number is already generated
                {
                    normalNumbers.Add(randomNumber); // add the number to the HashSet
                }
            }

            while (specialNumbers.Count < 2) // generate 2 unique random numbers
            {
                int randomNumber = random.Next(1, 12); // generate a random number between 1 and 100
                if (!specialNumbers.Contains(randomNumber)) // check if the number is already generated
                {
                    specialNumbers.Add(randomNumber); // add the number to the HashSet
                }
            }

            return new Tuple<HashSet<int>, HashSet<int>>(normalNumbers, specialNumbers);
        }


        /// <summary>
        /// Return a string of normal and special values
        /// </summary>
        /// <param name="hashNormals"></param>
        /// <param name="hashSpecial"></param>
        /// <returns></returns>
        public Tuple<string, string> ShowSelection(HashSet<int> hashNormals, HashSet<int> hashSpecial)
        {
            string normals = string.Empty;
            string specials = string.Empty;

            // Build the normal numbers string
            for (int i = 0; i < hashNormals.Count; i++)
            {
                if (i == hashNormals.Count - 1) normals += hashNormals.ToArray()[i].ToString();
                else normals += hashNormals.ToArray()[i].ToString() + ",";
            }


            // Build the special numbers string
            for (int i = 0; i < hashSpecial.Count; i++)
            {
                if (i == hashSpecial.Count() - 1) specials += hashSpecial.ToArray()[i].ToString();
                else specials += hashSpecial.ToArray()[i].ToString() + ",";
            }

            return new Tuple<string, string>(normals, specials);
        }
    }
}