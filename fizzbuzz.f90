program fizzbuzz
  implicit none
  integer i
  do i = 1, 100
    if (mod(i, 3) == 0 .and. mod(i, 5) == 0) then
      print *, "Fizz,Buzz"
    else if (mod(i, 3) == 0) then
      print *, "Fizz"
    else if (mod(i, 5) == 0) then
      print *, "Buzz"
    else
      print *, i
    end if
  end do
end program fizzbuzz
