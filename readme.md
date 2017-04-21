# Game Engines 2 Lab Test 1 2017

The video below shows a simulation of electrons orbiting the nucleus of an atom. The orbits of electrons are known as shells. Orbital shells are numbered from 1..n. The lower the number, the closer the shell is to the nucleus. Each  shell can hold a fixed number of electrons. In the simulation, each electron is travelling more or less around in it's shell, though the electron will wander a bit and not follow the shell exactly to make the simulation look a bit more interesting.

The configuration of electrons for each type of atom is given by a comma seperated string of numbers indicating the number of electrons present in each shell. For example, for the hydrogen atom the value is 1 meaning that hydrogen atoms have 1 electron orbiting in shell 1, whereas the signature for aluminium is 2,8,3 meaning that aluminium atoms have 2 electrons in shell 1, 8 electrons in shell 2 and 3 electrons in shell 3. Strontium has a signature of  2,8,18,8,2. This means that strontium atoms have 2 electrons in shell 1, 8 electrons in shell 2, 18 electrons in shell 3 and so on. The further out an electron is from the nucleus, the more energy it has and the faster it will move.

You are required to make a program in Unity that can create simulations of different atoms, given orbital shell configuration strings. Electrons should initially be spaced evenly around the nucleus. You should make an atom game component that has the following fields:

# Marking Scheme
| Description | Marks |
|-------------|-------|
| Instantiating and positioning electrons around the nucleus | 25 |
| Implementing a boid to steer the electrons | 15 |
| Implementing the orbiting behaviour | 25 |
| Implementing the wandering behaviour | 15 |
| Polish & flair | 20 |

Marks will be awarded for creative, elegent and efficient soultions.