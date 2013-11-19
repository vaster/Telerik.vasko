/*String is a class in C# and .Net giving the posibility of manipulating a string of symbols.
 In the primitive type Char we are able to save only one symbol,so we can assume that the
 string is a array of Chars(both ways has there negative and positive sides).
 
 When we create a variable of type string we should know that the value of our string is stored
 in the heap and the valiable itself only carries an address wich is pointing where in the heap
 is the value(reference type).
 
 It is important to know what happens when we try to manipulate somehow a string.
 -almost every manipulation done on a string does not change the string itselft, but
 creating a new one(this means that most of the operations on strings return a new one),
 thus a new address in the stack and a new value in the heap. We should know this process
 could be realy slow when we do multiple manipulations on strings and it is not very efficient.
 Good way to deal with this is by using StringBuilder.
 
 Importand methods:
 * -Compare
 * -CompareTo
 * -Concat or +
 * -Equals
 * -IndexOf
 * -LastIndexOf
 * -Split
 * -Replace
 * -Remove
 * -Substring
 * -Trim
 
 */