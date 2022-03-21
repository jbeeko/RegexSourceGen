open SourceGenedRegex

printf "Provide a phonenumber: "
let input = System.Console.ReadLine()
if PhoneNumbers.TenDigitNumber().IsMatch(input)
then printfn "%s is a phonenumber." input
else printfn "%s is not a phonenumber" input
