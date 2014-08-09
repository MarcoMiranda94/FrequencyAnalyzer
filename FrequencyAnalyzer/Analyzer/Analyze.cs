using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer
{
    public class Analyze
    {


        private List<Letter> listValues;
        public int total { get; set; }

        public Analyze()
        {
            addValues();
        }

        public List<Letter> getList()
        {
            return listValues;
        }

        public void analize(String st)
        {
            foreach (char c in st)
            {
                for (int i = 0; i < listValues.Count; i++)
                {
                    if (c == listValues[i].value)
                    {
                        listValues[i].count++;                        
                        break;
                    }
                }
            }
        }

        private void addValues()
        {
            listValues = new List<Letter>();
            listValues.Add(new Letter()
            {
                    count = 0,
                    value = 'a'
            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'b'
            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'c'
            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'd'
            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'e'
            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'f'
            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'g'
            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'h'
            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'i'
                          
            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'j'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'k'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'l'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'm'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'n'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'o'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'p'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'q'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'r'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 's'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 't'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'u'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'v'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'w'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'x'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'y'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = 'z'

            });
            listValues.Add(new Letter()
            {
                count = 0,
                value = ' '

            });

        }
    }
}
