# Game Engines 2 Lab Test 1 2017

The video below shows a simulation of electrons orbiting the nucleus of various atoms:

[![YouTube](https://img.youtube.com/vi/GOOTswCIGyM/0.jpg)](https://www.youtube.com/watch?v=GOOTswCIGyM)

Electrons are coloured blue in the video while the nucleus is coloured red. The orbits of electrons are known as *shells*. Orbital shells are numbered from 1..n. The lower the number, the closer the shell is to the nucleus. Each  shell can hold a fixed number of electrons. In this simulation, the number of electrons per shell for different elements is given by a comma seperated string of numbers. For example, hydrogen atoms have a value of "1" meaning that hydrogen atoms have 1 electron orbiting in shell 1. The value for aluminium is "2,8,3" meaning that aluminium atoms have 2 electrons in shell 1, 8 electrons in shell 2 and 3 electrons in shell 3. The value for Strontium is "2,8,18,8,2". This means that strontium atoms have 2 electrons in shell 1, 8 electrons in shell 2, 18 electrons in shell 3 and so on. Here is a [wikipedia article about electron shells](https://en.wikipedia.org/wiki/Electron_shell) that gives the full table of the number of electrons per shell for all the elements if you want to know more. 

The further out an electron is from the nucleus, the more energy it has and the faster it will travel. Also, electrons are travelling more or less around in their shells, though electrons will wander a bit and not follow the orbit exactly to make the simulation look a bit more interesting.

You are required to make a program in Unity that can create simulations of different atoms. Electrons should be spaced evenly in their shells and should orbit around the Y axis. You should make an game component called Atom that can be attached to an empty game object to instantiate the nucleus and the electrons from prefabs. The electron prefab should have appropriate game components that will get it to move as per the video. The Atom game component should have the following public fields:

```C#
public string electronsPerShell;
public string atom;
public GameObject protonPrefab;
public GameObject electronPrefab;
```

- You should start with a blank Unity project 
- *Create an empty public repository on github and commit your project to it regularly throughout the test in case something goes wrong and you need to roll back.*
- This is a closed book test. No use of Google or instant messaging
- [Submit your git repository link here](https://docs.google.com/forms/d/e/1FAIpQLSfnXDA2b9cWTneuvisfbRgHZwlccT3BJiR-MiRxvmk1M-pncQ/viewform)

You can use ```string.Split``` to split a comma seperated string and ```int.parse``` to convert a string to an integer.

# Marking Scheme
| Description | Marks |
|-------------|-------|
| Instantiating and positioning electrons around the nucleus | 25 |
| Implementing a boid to steer the electrons | 15 |
| Implementing the orbiting behaviour | 20 |
| Implementing the wandering behaviour | 15 |
| Correct use of git | 5 |
| Polish & flair | 20 |

Marks will be awarded for creative, elegent, efficient and beautiful soultions.

