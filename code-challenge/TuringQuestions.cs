namespace code_challenge;
public class TuringQuestions
{

        private bool IsValid(char lower, char upper){

            const string str1= "{}";
            const string str2= "[]";
            const string str3= "()";

            var arg  = string.Concat(lower,upper);

            if( arg.Equals(str1) ||
                arg.Equals(str2) ||
                arg.Equals(str3) 
            )
            return true;

            return false;
        }

        public string validateChars(string strChars)
        {
            int strLength = strChars.Length;
            if((strLength%2)!= 0){
                return "invalid";
            }
            
            int i =0;
            int n = strLength -1;

            while (i <= n){

                if(IsValid(strChars[i], strChars[i+1])){
                     i = i+2;
                }
                else if (IsValid(strChars[i], strChars[n])){
                    i =i +1;
                    n=n-1;
                }
                else{
                    return "invalid";
                }
            }
            return "valid";
        }

        public int calcPoint (string [] ops)
        {
            var result = 0;
            var resultLst = new List<string>();
            var ops1 = ops.ToList<string>();

            foreach (var item in ops1){
                if(item.Equals("+")){

                    var nxtItem = int.Parse(resultLst[resultLst.Count() - 1]) +  int.Parse(resultLst[resultLst.Count() - 2]) ;
                    resultLst.Add(nxtItem.ToString());

                    result = 0;

                    foreach (var i in resultLst){
                        result += int.Parse(i);
                    }



                }
                else if(item.Equals("D")){

                    var nxtItem = int.Parse(resultLst[resultLst.Count() - 1]) * 2 ;
                    resultLst.Add(nxtItem.ToString());

                    result = 0;

                    foreach (var i in resultLst){
                        result += int.Parse(i);
                    }

                }
                else if (item.Equals("C")){
                  
                    resultLst.RemoveAt(resultLst.Count() - 1);
                    result = 0;

                    foreach (var i in resultLst){
                        result += int.Parse(i);
                    }
                }
                else{

                    resultLst.Add(item);

                    foreach (var i in resultLst){
                        result += int.Parse(i);
                    }
                }
            }
            return result;
        }
}
