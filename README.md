# Verifier

Welcome to Verifier, a simple way of ensuring your data is what you need it to be. This library is intended to allow a user to ask a "compile ready English question" instead of implementing Boolean logic. If we need a List<T> alias to be neither null nor empty, we could:

```csharp
if ( list != null || !list.any() ) {
  // stuff
}
```  

Verifier allows us to:

```csharp
if ( Inquiry.IsNotNullOrEmpty(list) ){
   // stuff
}
```

At the onset, this is not overly impressive. The logic itself isn't intended to be. Verifier's value lies in the fact that it is nearly mistake and typo proof. Sure, we could screw up and use the "IsEmpty" function when we need "IsNullOrEmpty". However, Verifier protects us from having a '!' in the wrong place, or forgetting to add _string.Trim()_ when we need to check for white space. Instead of using energy on Boolean algebra, Verifier allows us to just use English.

### Usage

#### Inquiry

The Inquiry Suite allows you to ask a yes/no question about the state of your data. Some of the functions in this suite feel very similar, or even duplicative of functions natural to the C# API. I debated on the duplication. Ultimately, I felt like delivering a "complete" product would __not require users to know if they should be invoking calls from Verifier or from C# itself__.

```csharp
var a = Inquiry.IsNull(null); // true

var b = Inquiry.IsNotNull(null); // false

var c = Inquiry.IsMeetingMinimumLength("New Account Password", 10); // true
```

Inquiry functions are designed to integrate well with control structures. They are not meant to be disruptive.

```csharp
var myList = new List<bool>(new bool[] { TRUE, FALSE });

if ( Inquiry.IsNullOrEmpty(myList) ) {
  return defaulValues;
}
else {
  return myList;
}
```


#### Verify

The Verify suite sits on top of Inquiry. Verify functions do nothing other than invoke Inquiry and throw VerifyExceptions if data is found to be in an illegal state. They inherently disrupt "happy path execution".

```csharp

var email = verifier@gihub.com;
try
{
   Verify.ValidEmail(email);
   client.SendEmail(email);
}
catch (VerifyException e)
{
   throw new Exception("Not a valid email address.", e);
}
```

Verify functions are designed to act as either a green or red light regarding the safety of whatever code comes next.

```csharp
public List<things> DisplayThings(RestRequest request) {
   Verify.NotNullOrEmpty(request.json.listOfThings);

   foreach( thing in request.json.ListOfThings )
   {
      ...
      // Safely do UI things
      ...
   }
}
```
