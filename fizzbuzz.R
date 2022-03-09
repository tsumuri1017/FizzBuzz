fb1<-function(n){
  fb<-character(n)
  for(i in 1:n){
    if(i%%3==0&&i%%5==0)
      fb[i]<-"FizzBuzz"
    else
      if(i%%3==0)
        fb[i]<-"Fizz"
    else
      if(i%%5==0)
        fb[i]<-"Buzz"
    else
      fb[i]<-i
  }
  fb
}
