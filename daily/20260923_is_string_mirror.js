/*
String Mirror

Given two strings, determine if the second string is a mirror of the first.

    A string is considered a mirror if it contains the same letters in reverse order.
    Treat uppercase and lowercase letters as distinct.
    Ignore all non-alphabetical characters.

Tests:

    Waiting: 1. isMirror("helloworld", "helloworld") should return false.
    Waiting: 2. isMirror("Hello World", "dlroW olleH") should return true.
    Waiting: 3. isMirror("RaceCar", "raCecaR") should return true.
    Waiting: 4. isMirror("RaceCar", "RaceCar") should return false.
    Waiting: 5. isMirror("Mirror", "rorrim") should return false.
    Waiting: 6. isMirror("Hello World", "dlroW-olleH") should return true.
    Waiting: 7. isMirror("Hello World", "!dlroW !olleH") should return true.
*/

/** MY SOLUTION */

function isMirror(str1, str2) {
  function isAlphabet(char) {
    return char.length == 1 && char.match(/[a-z]/i)
  }
  
  console.log(str1, str2, '\n')

  str1 = [...str1].filter((x) => isAlphabet(x));
  str2 = [...str2].filter((x) => isAlphabet(x));

  if (str1.length != str2.length)
    return false

  return str1.reduce((out, _, idx) => {
    return out = out && (
      str1[idx] == str2[str2.length-idx-1])
    }, true);
}

/** GEMINI REFACTORING */

function isMirrorGemini(str1, str2) {
  // 1. Rimuoviamo tutti i caratteri non alfabetici usando replace e la regex
  const clean1 = str1.replace(/[^a-zA-Z]/g, "");
  const clean2 = str2.replace(/[^a-zA-Z]/g, "");

  // 2. Controllo della lunghezza
  if (clean1.length !== clean2.length) return false;

  // 3. Confronto carattere per carattere usando le stringhe pulite
  return [...clean1].every((char, idx) => {
    return char === clean2[clean2.length - 1 - idx];
  });
}