<img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="150px" height="150px" /> 


# Mic_Volo

##  Mic_Volo Training Program
## Projects
* [HelloWord] 

[HelloWord]: https://github.com/lusinekh/Mic_Volo/tree/master/Mic_Volo.HelloWord


* [Fibonacci] 

[Fibonacci]: https://github.com/lusinekh/Mic_Volo/tree/master/FibonacciSequrenc
<h3>
Established the fibonacci function that returns the IEnumerable interface and it will be possible to make Linq actions
  
  
  
```C#
  public static IEnumerable<BigInteger> Fibonacci()
        {
           BigInteger frste =new BigInteger(0);
           BigInteger last = new BigInteger(1);
           BigInteger res = new BigInteger(0);
           
           yield return frste;
           yield return last;
           while(true)
           {           
                res = frste + last;
                frste = last;
                last  =  res;
                yield return res;
           }  
        }
  
```

* [Translate] 

[Translate]: https://github.com/lusinekh/Mic_Volo/blob/master/Translate/Translate/TranslateExtensions.cs

<h2>
 This program contains the ToArenian extension method, which translates Latin letters into Armenian letters
  
  
  ```C#          
            str = str.ToLower();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("a", "ա");
            dictionary.Add("b", "բ");
            dictionary.Add("g", "գ");
            dictionary.Add("sh", "շ");            .
            .
            .
            string result = String.Empty;
            int i = 0;
            while (i < str.Length)
            {
                if (str[i] == 't' && str[i + 1] == 'h')
                {
                    result += dictionary["th"];
                    i += 2;
                    continue;
                }
                if (str[i] == 'k' && str[i + 1] == 'h')
                {
                    result += dictionary["kh"];
                    i += 2;
                    continue;
                }
                result += dictionary[str[i].ToString()];
                i++;
             }
               
               

