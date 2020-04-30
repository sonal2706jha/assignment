import {circle,rectangle,cylinder} from './Area'

import test from './filter.js';
console.log(test());

//Ques1.Given this array: `[3,62,234,7,23,74,23,76,92]`, Using arrow function, create an array of the numbers greater than `70`.
const numbers = [3, 62, 234, 7, 23, 74, 23, 76, 92];

 const greater = numbers.filter(number => number > 70);

 console.log(greater);


 //Ques4.Filter unique array members using Set.
 let arr = ["7", "0", "6", "10", "8", "9", "11", "7", "4", "6", "10", "8", "9", "11", "7", "4", "6", "10", "8", "9", "11", "7", "4", "6", "10", "8", "9", "11", "7", "4", "6", "10", "8", "9", "11", "7", "4", "6", "10", "8", "9", "11"];

let filteredArray = arr.filter(function(item, pos){
  return arr.indexOf(item)== pos;
});

console.log( filteredArray );

//Ques5 Find the possible combinations of a string and store them in a MAP?
function getAll(string)
{
    var results = [];

  if (string.length === 1) {
    results.push(string);
    return results;
  }

  for (var i = 0; i < string.length; i++) {
    var char1 = string[i];
    var char2 = string.substring(0, i) + string.substring(i + 1);
    var inner = getAll(char2);
    for (var j = 0; j < inner.length; j++) {
      results.push(char1 + inner[j]);
    }
  }
  return results;
}

console.log('Q 5 : ');
console.log(getAll("abc"));
//Q6Write a program to implement inheritance upto 3 classes.The Class must  public variables and static functions.
class Animal {

  constructor(name) {
    this.speed = 0;
    this.name = name;
  }

  run(speed) {
    this.speed = speed;
    alert(`${this.name} runs with speed ${this.speed}.`);
  }

  stop() {
    this.speed = 0;
    alert(`${this.name} stands still.`);
  }

}

class Lion extends Animal {
  hide() {
    alert(`${this.name} hides!`);
  }

  stop() {
    super.stop(); //for calling parent
    this.hide();
  }
}
class Cube extends Lion {
  hide() {
    alert(`${this.name} hides!`);
  }

  stop() {
    super.stop(); //for calling parent
    this.hide();
  }
}



let cube = new Cube("Cube");

cube.run(10);
cube.stop();



//Q7 Write a program to implement a class having static functions

class Test
{
  static display1()
  {
    return "static method is invoked"
  }
  static display2()
  {
    return "static method is invoked again"
  }
}
console.log(Test.display1());
console.log(Test.display2());

//Q12Implement Map and Set using Es6
const map1 = new Map();
map1.set('bar', 'foo');

console.log(map1.get('bar'));
console.log(map1.get('baz'));

//Ques8


//Q9

//console.log("Ques 9",Filter);



//Ques10  Write a program to flatten a nested array to single level using arrow functions.
var flatten = function(a, shallow,r){
  if(!r){ r = []}

if (shallow) {
  return r.concat.apply(r,a);
  }

   for(var i=0; i<a.length; i++){
        if(a[i].constructor == Array){
            flatten(a[i],shallow,r);
        }else{
            r.push(a[i]);
        }
    }
    return r;
}

console.log("Q10:"+flatten([1, [2], [3, [[4]]],[5,6]]));

console.log("Q10:"+flatten([1, [2], [3, [[4]]],[5,6]], true));

//Ques4Extract all keys inside address object from user object using destructuring ?

/*const user = {
firstName: ‘Sahil’,
lastName: ‘Dua’,
Address: {
Line1: ‘address line 1’,
Line2: ‘address line 2’,
State: ‘Delhi’,
Pin: 110085,
Country: ‘India’,
City: ‘New Delhi’,
},
phoneNo: 9999999999
}*/
const user = {
firstName: 'Sahil',
lastName: 'Dua',
Address: {
Line1: 'address line 1',
Line2: 'address line 2',
State: 'Delhi',
Pin: 110085,
Country: 'India',
City: 'New Delhi',
},
phoneNo: 9999999999
};
let{Line1,Line2,State,Pin,Country,City}=user.Address;
console.log("Q4 : " + Line1,Line2,State,Pin,Country,City);

//Ques3Create a markup template using string literal

/*const song = {
 name: 'Dying to live',
 artist: 'Tupac',
 featuring: 'Biggie Smalls'
};
Result:
"<div class="song">
   <p>
     Dying to live — Tupac
     (Featuring Biggie Smalls)
   </p>
 </div>
“*/
const song = {
 name: 'Dying to live',
 artist: 'Tupac',
 featuring: 'Biggie Smalls'
};
const literal = `<div class="song">
        <p>
            ${song.name} - ${song.artist}
            (Featuring ${song.featuring})
        </p>
    </div>`;

console.log("Q3 : "+literal); // printing the result by using literal template
//Q11  Implement a singly linked list in es6 and implement addFirst() addLast(), length(), getFirst(), getLast(). (without using array)
class LinkedList {
  constructor() {
    this.head = null;
    this.tail = null;
    this.count = 0;
  }

  get length() {
    return this.count;
  }

  addLast(data) {
    // Create a new Node
    const node = {
      data: data,
      next: null
    }

    if(this.count === 0) {
      // If this is the first Node, assign it to head
      this.head = node;
    } else {
      // If not the first node, link it to the last node
      this.tail.next = node;
    }

    this.tail = node;

    this.count++;
  }

  addFirst(data) {
    // Create a new Node
    const node = {
      data: data,
      next: null
    }

    // Save the first Node
    const temp = this.head;

    // Point head to the new Node
    this.head = node;

    // Add the rest of node behind the new first Node
    this.head.next = temp;

    this.count++;

    if(this.count === 1) {
      // If first node,
      // point tail to it as well
      this.tail = this.head;
    }
  }

  removeFirst(data) {
    if(this.count > 0) {
      // The head should point to the second element
      this.head = this.head.next;

      this.count--;

      if(this.count === 0) {
        // If list empty, set tail to null
        this.tail = null;
      }
    }
  }

  removeLast(data) {
    if(this.count > 0) {
      if(this.count === 1) {
        this.head = null;
        this.tail = null;
      } else {
        // Find the Node right before the last Node
        let current = this.head;
        while(current.next !== this.tail) {
          current = current.next;
        }

        current.next = null;
        this.tail = current;
      }
    }
  }

  printOut(log) {
    let current = this.head;
    while(current) {
      log(current.data);
      current = current.next;
    }
  }
}

var linkedList = new LinkedList();
console.log("Q11:");
console.log("Initial count: " + linkedList.length);

linkedList.addLast(2);
linkedList.addLast(78);
linkedList.addFirst(34);
linkedList.removeLast();
linkedList.addFirst(1);
linkedList.addLast(4);
linkedList.addFirst(55);
linkedList.removeFirst();

linkedList.printOut(console.log);

//Ques13 Implementation of stack (using linked list)

var Example = {};

/*
* Linked List node with item object and next pointer to another node
*/
Example.StackNode = function(){
this.item = null;
this.next = null;
}

Example.LinkedStack = function(){
var head = null;
var size = null;

/**
* Push function
* itereate through the list and then add the node to the last node in the list
*/
this.pushToStack = function(item){
var node = new Example.StackNode();
node.item = item;
node.next = null;
if(size < 1 && head === null){
  head = node;
  head.next = null;
  size = 1;
}else{
  var current = head;
  while(current.next !== null){
    current = current.next;
  }
  current.next = node;
  size += 1;
}
}

/**
* Pop Function
* Iterate through the list and grab the last item and remove it from list
*/
this.popFromStack = function(){
var current = head;
if(size === 0){
  return;
}
if(size === 1){
  head = null;
  size = 0;
  return current;
}
var prev = current;  // 543
while(current.next !== null){
    prev = current;
    current = current.next;
}
prev.next = null;
size -= 1;
return current;
}

// Function to check if stack is empty
this.isStackEmpty = function(){
return (size < 1) ? true : false;
}

// Function to get top item of the stack
this.stackTop = function(){
var current = head;
if(size > 0 && head !== null){
  while(current.next !== null){
    current = current.next;
  }
  return current.item;
}else{
  console.log("There is no item in the stack");
  return null;
}
}

this.printStack = function(){
var current = head;
while(current.next !== null){
  console.log("Item "+current.item + " is on the stack.");
  current = current.next;
}
console.log("Item "+current.item + " is on the stack.");
}

}

console.log("Q13:");

var stack = new Example.LinkedStack();
console.log(stack.isStackEmpty());
var top = stack.stackTop();
console.log(top);
stack.pushToStack("Test1");
console.log(stack.stackTop().item);
stack.pushToStack("Test2");
stack.pushToStack("Test3");
stack.printStack();
var poped = stack.popFromStack();
console.log("Popped item is: " + poped.item);
stack.printStack();

//Q2/*Ques 2:
/*<ul>
  <li data-time="5:17">Flexbox Video</li>
  <li data-time="8:22">Flexbox Video</li>
  <li data-time="3:34">Redux Video</li>
  <li data-time="5:23">Flexbox Video</li>
  <li data-time="7:12">Flexbox Video</li>
  <li data-time="7:24">Redux Video</li>
  <li data-time="6:46">Flexbox Video</li>
  <li data-time="4:45">Flexbox Video</li>
  <li data-time="4:40">Flexbox Video</li>
  <li data-time="7:58">Redux Video</li>
  <li data-time="11:51">Flexbox Video</li>
  <li data-time="9:13">Flexbox Video</li>
  <li data-time="5:50">Flexbox Video</li>
  <li data-time="5:52">Redux Video</li>
  <li data-time="5:49">Flexbox Video</li>
  <li data-time="8:57">Flexbox Video</li>
  <li data-time="11:29">Flexbox Video</li>
  <li data-time="3:07">Flexbox Video</li>
  <li data-time="5:59">Redux Video</li>
  <li data-time="3:31">Flexbox Video</li>
</ul>
a. Select all the list items on the page and convert to array.
b. Filter for only the elements that contain the word 'flexbox'
c. Map down to a list of time strings
d. Map to an array of seconds
e. Reduce to get total using .filter and .map */

console.log("Q2 : Done on the Ques2.html page that You can find in the './build/Ques2.html' in the build folder");
