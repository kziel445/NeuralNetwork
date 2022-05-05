# NeuralNetwork
Application created with windows form app

![Screenshot](Images/app1.png)<br>

Scheme:<br>
x y //inputs<br>
a : b c | d : e f // first hidden layer<br>
g: h i<br><br>

b - value on edge from input x(first input) to first hidden layer first node <br>
c - value on edge from input y(second input) to first hidden layer first node <br>
e - value on edge from input x(first input) to first hidden layer second node <br>
f - value on edge from input y(second input) to first hidden layer second node <br>
a and d - edges from cons hidden input(value = 1)<br>
h - value on edge from previous layer first node(node with edges: a,b c) to this layer(second hidden layer) first node(only one node)<br>
i - value on edge from previous layer first node(node with edges: d,e f) to this layer(second hidden layer) first node(only one node)<br>
g - edge from cons hidden input(value = 1)<br>
<br>
hidden layer symbols:<br>
: - before symbol edge from const node (value = 1), on the right edges from outputs from previous layer<br>
| - separates nodes<br>
<br>


Example:<br>
0 0 // 2 inputs<br>
0,62 : 0,95 0,39 | 0,96 : 0,29 0,13 // hidden layer with 2 nodes<br>
0,92 : 1,00 0,57 // hidden layer with 1 node<br>

![Screenshot](Images/app4.png)<br>
