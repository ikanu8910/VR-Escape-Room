# VR Escape Room
#### Unity Version: 2020.3.17f1

### Portfolio Description:
The goal of this group project was to create a themed escape room that had three puzzles. By having access to a black box theater with motion capture sensors, one of the puzzles was required to be a motion trackable object. Given restrained physical space parameters of roughly 36 square feet, the main design challenge was creating and building a large room that allowed for free virtual movement and did not induce simulator sickness. This was overcome by my incorporation of VR teleportation using Unity's Virtual Reality ToolKit (VRTK) package.

I was the sole designer of the entire office space theme in Unity, and I was the sole programmer for the motion trackable object puzzle.
Link to video of the project: https://vimeo.com/966857693


#### Please Note:
1.Sometimes our project will open with an untitled sample scene. As a result, you will need to click specifically into our scene titled Project 2 in the assets folder upon opening our project. 
2.We recorded our project video then made some final edits afterwards that were not yet reflected in the video. So the timer and puzzle solved text location and color in the game is different that whats shown in our final video. 
3.You most likely will need to run our project on a desktop, especially when connecting to an HMD.
4.VRTK teleportation might not run after connecting to the Qualisys system.


#### Designing the Escape Room
We went with an office theme layout. The scale of the layout is 1 unit = 1 inch. First, we aligned our room by setting the floor at the origin. Then, we added our tracked object to the scene. While moving along the perimeter of the BBX, we rotated the office layout in our scene to ensure that it was congruent with the BBX. Lastly, we picked a corner in the BBX to act as our 'new' origin. We did this by moving our tracked object to the center of a corner in the BBX, noted those coordinates, and then moved our entire scene to have its center be the new points we obtained.

The user should start in the center of our scene, which maps to the back and righthand corner of the BBX upon entering from the BBX entrance. 


#### The Three Puzzles
The first puzzle involves having the user move a tile with the letter 'H' on it, that is hidden in plain sight, to the correct location on the bulletin board. The tile is located underneath the bulletin board. The tile should be placed in a way that has the tiles on the bulletin board read 'Fahrenheit 451'. Once this puzzle is solved, the first stack of papers on the table in front of the bulletin board will turn blue signaling puzzle completion.

The second puzzle is based on the clue of the first puzzle. Fahrenheit 451 is a popular novel by Ray Bradbury. Many people have either read the novel or know the thematic cultural reference of burning books. We use this as a clue to suggest that people go look for a book on the bookshelf within the scene. We have a few bookshelves within our scene. But one bookshelf in particular has a red book that stands out. Once the user has removed the red book from the bookshelf and reveals the magnifying glass (our tracked object) hidden behind it, they have completed the second puzzle. The second stack of papers on the table in front of the bulletin board will also turn blue signaling puzzle completion.

The last puzzle involves the user using the magnifying glass to find the code/key combination to unlock the door and escape the office. The user will need to move back to the desk and hover the magnifying glass over a stack of papers. When hovering over the third set of papers, the magnifying glass will reveal the door combination, which completes the third puzzle. 

To escape the room, the user will need to collide with the door after the third puzzle is completed. If the user runs out of time to escape the room, the screen will freeze then turn black. If the user completes the escape room in time, purple text will appear signaling that the user has escaped the room.


#### Additional Graduate Element
We found an article by ACM titled 'Evaluating the Effects of Four VR Locomotion Methods: Joystick, Arm–Cycling, Point–Tugging, and Teleporting'. This article evaluated four different methods for exploring a large, immersive virtual environment while having physical constraints. From reading this article, we decided to incorporate teleportation. Teleportation involves the user using a VR controller to display an arc that extends from the controller to the ground of the virtual location. Users can modify this arc to highlight different environment points, which they can then 'jump' to instantaneously. From reading the article, it described that the fundamental "advantage of teleporting is that it reduces the effects of simulator sickness" (Coomer et al., pg 1). 

There were multiple reasons why we chose to incorporate teleportation. The reduced effect of simulator sickness was one of the main reasons we incorporated teleportation. Also, one of the team members had experience using teleportation with a Unity package called VRTK. Lastly, we liked that we didn't have to worry too much about the impact of the BBX size on the size of our virtual environment. By incorporating teleportation, we are able to confine the user to a small area within the BBX but still have a large virtual environment that they can explore.

Article Citation: 
Noah Coomer, Sadler Bullard, William Clinton, and Betsy Williams-Sanders. 2018. Evaluating the effects of four VR locomotion methods: joystick, arm-cycling, point-tugging, and teleporting. In Proceedings of the 15th ACM Symposium on Applied Perception (SAP '18). Association for Computing Machinery, New York, NY, USA, Article 7, 1–8. DOI:https://doi.org/10.1145/3225153.3225175


#### Controller Instructions
The side button on the right VR controller is used to grab and move objects.
The right VR controller "a" button 'touch' is used to angle the green, curved transportation line.
The right VR controller "a" button 'press' is used to instantly teleport to the correct location.
