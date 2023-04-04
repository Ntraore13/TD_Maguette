using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTraining
{
    public static class Algo
    {
        /// <summary>
        /// retourne un boolean indiquant si le tableau contient la valeur v
        /// </summary>
        internal static bool ArrayContains(int[] array, int v)
        {
            foreach (int nb in array)
            {
                if (nb == v)
                {
                    return true;
                }
            }
            return false;

        }

        /// <summary>
        /// retourne un tableau de int contenant les valeurs présentent en plus d'un exemplaire dans array
        /// </summary>
        /*
         * pour chaque nombre presente dans le tableau 
         * recheche si nombre est egal a un autre nombre du tableau 
         * stocke le**/
        internal static int[] ArrayDuplicate(int[] array)
        {
            int taille = array.Length;
            int nb;
            List<int> tab = new List<int>();

            for (int i = 0; i < taille; i++)
            {
                int count = 0;
                nb = array[i];

                for (int j = 0; j < taille; j++)
                {
                    if (nb == array[j])
                    {
                        count++;
                        // on cherche a savoir si count est sup a 1 et si le nb existe deja dans la liste
                        // Contains pour voir si un element est dans la liste ou dans le tableau
                        if ((count > 1) && (tab.Contains(nb) == false))
                        {
                            tab.Add(nb);
                        }


                    }
                }

            }
            return tab.ToArray();
        }

        /// <summary>
        /// retourne la valeur maximal du tableau array
        /// </summary>

        /**
         * 
         * pour chaque nombre i dans array
         * si i superieur au minimum
         * on garde le nombre dans max
         * 
         * sinon rien
         */
        internal static int ArrayMax(int[] array)
        {
            int max = array[0];
            foreach (int nb in array)
            {
                if (nb > max)
                {
                    max = nb;
                }
            }
            return max;

        }

        /// <summary>
        /// retourne la valeur minimum du tableau array
        /// </summary>

        /**
         * pour chaque nombre i dans array
         * si i inferieur au minimum
         * on garde le nombre dans min
         * 
         * sinon rien
         */
        internal static int ArrayMin(int[] array)
        {
            int min = 999;

            foreach (int i in array)
            {
                if (min == 999)
                {
                    min = i;
                }
                if (i < min)
                {
                    min = i;
                }
                else
                {

                }
            }
            return min;

        }

        /// <summary>
        /// retourne le char à la position v de la string str
        /// </summary>
        internal static char StringCharAt(string str, int v)
        {
            char[] charArr = str.ToCharArray();
            return charArr[v];

        }

        /// <summary>
        /// retourne un boolean indiquant si la string str contient le char v
        /// </summary>
        internal static bool StringContains(string str, char v)
        {
            char[] charArr = str.ToCharArray();
            foreach (var l in str)
            {
                if (l == v)
                {
                    return true;
                }

            }
            return false;
        }

        /// <summary>
        /// retourne un boolean indiquant si l'un des deux array en paramètre est contenu dans l'autre tableau
        /// </summary>
        internal static bool ArrayIsSubset(int[] array, int[] array2)
        {
            foreach (int i in array2)
            {
                if (array.Contains(i) == false)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// retourne un int indiquant l'index du premier char de la string v dans la string str
        /// </summary>
        internal static int StringIndex(string str, string v)
        {
            // IndexOf permet de recupérer l'index du premier caractere du string v dans la string str
            return str.IndexOf(v);
        }

        /// <summary>
        /// retourne un int indiquant le nombre de chiffres paires dans array 
        /// </summary>
        internal static int ArrayCountEvenNumber(int[] array)
        {
            int count = 0;

            foreach (int nb in array)
            {
                if (nb % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// retourne un nouvel array trier du plus petit au plus grand (ascendant)
        /// </summary>
        internal static int[] ArraySortAsc(int[] array)
        {
            int taille = array.Length;

            for (int i = 0; i < taille; i++)
            {
                for (int j = i + 1; j < taille; j++)
                {
                    if (array[i] > array[j])
                    {
                        int nb = array[i];
                        array[i] = array[j];
                        array[j] = nb;
                    }
                }

            }
            return array;
        }

        /// <summary>
        /// retourne le plus grand nombre de caractères communs continu (ie. la taille de la plus longue série de char que les deux str ont en commun)
        /// </summary>
        internal static int StringContinuousChar(string str, string str2)
        {
            throw new NotImplementedException();
        }
    }
}
