# Creative-Making-Sheep-Dog

git link：https://git.arts.ac.uk/22019706/Creative-Making-Sheep-Dog

video link：https://vimeo.com/835339496?share=copy

## Part1 Format - interactive innovation
Personally, I am very interested in physical interaction.

So I want to do projects with physical interaction. The physical interactions are basically developed using arduino, but from time to time arduino will report errors and even run bugs due to some inexplicable problems (I think arduino is very sensitive.) On the other hand, I think I already have a basic knowledge of arduino development, so I would like to explore the development of some body movement sensors like kinect, leap motion etc.The leap motion is a device that captures the movement of the hands，which I want to have a try about it.

> Body transfer illusion is the illusion of owning either a part of a body or an entire body other than one's own, thus it is sometimes referred to as "body ownership" in the research literature. It can be induced experimentally by manipulating the visual perspective of the subject and also supplying visual and sensory signals which correlate to the subject's body. For it to occur, bottom-up perceptual mechanisms, such as the input of visual information, must override top-down knowledge that the certain body (or part) does not belong. This is what results in an illusion of transfer of body ownership. It is typically induced using virtual reality.
> 
> from wiki
>
 This experiment led me to a new way of interacting:

<img width="791" alt="image" src="https://github.com/CarlyLiu/Sheep-Dog/assets/112803802/9a40a059-ccff-4c6f-9027-b41d372e2117">

<img width="669" alt="c35f1e5357b5106e25995cf6611faab" src="https://git.arts.ac.uk/storage/user/555/files/78779fbe-7dc0-4e77-8c31-f15c6eae0c55">

We put a screen on top of a physically realistic box and display a virtual box space on the screen, put your hand in the box, and feed back the user's experience by overlapping the space and displaying an avatar in the virtual space.

I knew that if I needed to make the virtual space feel real to the user, then the visual part would be more demanding than the part I was capable of, so I invited Liaoran Zhang to team up to do it, so that I could do more with the output of the project.
## Part2 Concept - sheepdog

We have decided on a format, but not on the content part of the theme. A team means that you can't do what you want, you have to agree as a team, so we had a discussion about the theme part and out of a range of alternatives, only the concept of sheepdogs was something we all agreed on, so we decided to drop the tangle and go with the theme of sheepdogs.

<img width="723" alt="6f198338938ab896f4a87acad2c6b9b" src="https://git.arts.ac.uk/storage/user/555/files/c009bb05-d4ae-4196-80d0-813da270477e">

The user can control the position of the sheepdog by moving the hand to herd the sheep.Complete the game when all the sheep have been herded into the sheep pen. We can also adjust the difficulty of the game by adjusting the number of sheep and the movement parameters.

## Part3 Process
I am mainly responsible for the technical implementation part.

Leap motion has unity and unreal development software.

However, when connecting to the example to run it, the errors were reported and they did not work. Lieven recommended developing with unity and gave me some learning materials, which helped me a lot in my work.

**It is clear that there are three main components:**
1. leap motion: the connection of entities interacting with each other
2. flock: the implementation of the boid algorithm
3. combining the first two parts

### Part3.1 Leap motion
The main problem with the body movement sensors product is that the code is too old and incompatible with current software.And the whole volume of plugin is huge.
The problem specific to leap motion is that it is primarily used for VR development, so most of the samples available for study are from VR scenarios and are not applicable to the environment we are designing for. So after a period of getting to know the plugin better, I learnt that I could adjust the different manger to switch to desktop mode.

Then I created a leap motion based interaction scenario based on a sample to go through user testing.The demonstration is as follows:

https://git.arts.ac.uk/storage/user/555/files/7b08ca36-4c6f-4d10-95ad-09d83da1fbd4

Then I tested it with my classmates between classes and everyone would ENJOY the experience, which I hadn't expected, probably because I had spent so much time on the development that I was already very familiar with it. I also found out that there was a tracking problem, where the user did not know what was wrong with the motion capture, and this affected the experience. So we need to give feedback to the user in a timely manner. After adding the hand avatar to the scene, the user will be able to sense the tracking problem by the sudden disappearance of the hand avatar, so they will try to re-capture the experience by trying to track the location, pose, etc. more easily.

![b27fcdeff479fc704f90c22120dc3ab](https://git.arts.ac.uk/storage/user/555/files/8bf529ad-4661-4e84-ad29-c8a151b13157)
>Proud tries her best to experience.

### Part3.2 Boid
We studied the bird flock algorithm, which is part of the reason why I thought of the flock， when we were coding two.However, the changes were made using c++ in the framework of open frameworks.Judging from the results, I underestimated the difficulty of running the bird flock algorithm in unity.

reference about boid in unity：

https://codeload.github.com/SebLague/Boids/zip/refs/heads/master

https://codeload.github.com/easonyu0203/Boid-2D-Unity/zip/refs/heads/main

https://codeload.github.com/kalanadis/2D_FLOCKING/zip/refs/heads/master

https://codeload.github.com/RafaelKuebler/Flocking/zip/refs/heads/master

https://codeload.github.com/kbrizov/Boids-2D/zip/refs/heads/master

Our flock is moving in two dimensions in three dimensions because it is a diorama in virtual space.The learning sample boid is available in 2D and 3D but does not run 2D in 3D.This means that I cannot develop directly from open source code.This makes it very much more difficult to learn, because instead of a single script, there are multiple linked scripts that are encapsulated in the learning sample.

### Part3.3 Combine
This experience has taught me that projects should not be tweaked in two scene and then combined together, but should be written in one file from the start:(.Because there will always be many unknown problems when it comes to integrating together. For example: problems with size specifications etc.

![1eb93c2aaa701029a729b311c435fc7](https://git.arts.ac.uk/storage/user/555/files/9b3cf9a2-738f-44de-a6ba-27e2b4d9d850)

![f172ec1f4f29e195977459c47a01077](https://git.arts.ac.uk/storage/user/555/files/46d9f072-c0c2-410b-b549-b1c6b6ad12f3)

## Part4 conclude
Due to time and manpower issues (just me and Liaoran Zhang) there is still a gap between our proposal and the implementation, for example sheepdog will bark when you shake your fist, the impact factor will be doubled, the sketch of the story introduction before the game starts and so on are yet to be done.

As well as discovering the problem of eye-candy, many parts are theoretically possible, but in practice various problems arise.

## Part5 future explore
There is also the tactile exploration of VR, if we set up the physical real box with just a hole to reach into. Would the unknown of the physical space then make our perceptions go to a certain extent to believe in the realism of VR, and if our virtual space is on grass, would this realism be enhanced to a certain extent if we also lay a layer of something that is grass to the touch inside the physical box.
