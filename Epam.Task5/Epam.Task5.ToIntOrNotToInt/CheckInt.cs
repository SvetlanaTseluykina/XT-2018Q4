using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.ToIntOrNotToInt
{
    public static class CheckInt
    {
        public static bool CheckNumber(this string str)
        {
            str = str.ToUpper();
            bool fl = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]) || str[i].Equals('E') || str[i].Equals('+') || str[i].Equals('-') || str[i].Equals(','))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            char[] arr1 = new char[1];
            char[] arr2 = new char[1];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals(','))
                {
                    arr1 = str.ToCharArray(0, i);
                    arr2 = str.ToCharArray(i + 1, str.Length - i - 1);
                    fl = true;
                    break;
                }
            }

            if (fl)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (!char.IsDigit(arr1[i]) && arr1[i] != '+' && arr1[i] != '-')
                    {
                        return false;
                    }
                }

                if (arr1[0] != '+' && arr1[0] != '-' && !char.IsDigit(arr1[0]))
                {
                    return false;
                }

                if (!char.IsDigit(arr2[0]))
                {
                    return false;
                }

                int count = 0;
                int indexOfE = 0;
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (arr2[i].Equals(',') || arr2[i].Equals('-') || arr2[i].Equals('+'))
                    {
                        return false;
                    }
                    else if (arr2[i] == 'E')
                    {
                        indexOfE = i;
                        count++;
                    }
                }

                if (count != 1)
                {
                    return false;
                }

                count = indexOfE;
                int count2 = arr2.Length - indexOfE - 1;
                
                if (count < count2 || count <= (int)char.GetNumericValue(arr2.ElementAt(indexOfE + 1)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (!char.IsDigit(str[0]) && !str[0].Equals('+') && !str[0].Equals('-'))
                {
                    return false;
                } 

                if ((str[0].Equals('+') || str[0].Equals('-')) && !char.IsDigit(str[1]))
                {
                    return false;
                }

                if (str.Length <= 2)
                {
                    if (str.Length == 2 && char.IsDigit(str[0]) && !char.IsDigit(str[1]))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }  
                }
                else
                {
                    int count1 = 0;
                    int count2 = 0;
                    int indexOfE = 0;
                    int indexOfMinus = 0;
                    for (int i = 1; i < str.Length; i++)
                    {
                        if (str[i].Equals(',') || str[i].Equals('+'))
                        {
                            return false;
                        }
                        else if (str[i].Equals('E'))
                        {
                            count1++;
                            indexOfE = i;
                        }
                        else if (str[i].Equals('-'))
                        {
                            count2++;
                            indexOfMinus = i;
                        }
                    }

                    if (count1 == 0 && count2 == 0)
                    {
                        return true;
                    }
                    else if (count1 == 0 && count2 > 0)
                    {
                        return false;
                    }
                    else if (count1 > 1)
                    {
                        return false;
                    }
                    else if (count1 == 1 && count2 == 0)
                    {
                        if (indexOfE == str.Length - 1)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        int countZero = 0;
                        for (int i = 1; i < indexOfE; i++)
                        {
                            if (str[i] != '0' && char.IsDigit(str[i - 1]))
                            {
                                return false;
                            }
                            else if (str[i] == '0')
                            {
                                countZero++;
                            }
                        }

                        if (str.IndexOf('-') - 1 != indexOfE)
                        {
                            return false;
                        }
                        else if (indexOfMinus == str.Length - 1)
                        {
                            return false;
                        }
                        else
                        {
                            string substr = str.Substring(indexOfMinus + 1);
                            int number = 0;
                            for (int i = 0; i < substr.Length; i++)
                            {
                                number *= 10;
                                number += (int)char.GetNumericValue(substr[i]);
                            }

                            if (countZero >= number)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
        }
    }
}
