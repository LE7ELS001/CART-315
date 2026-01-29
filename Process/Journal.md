# Weekly Class Journal
___
## January 15-22 - Week 1 Design Journal – Make a Thing
This week, I wanted to see if I could make a small but complete playable game within a very limited amount of time. I was also interested in figuring out which parts of game development are worth spending time on when working on a short prototype. 

Before starting the project, I tried working with both Bitsy and Unity. Bitsy feels more focused on storytelling and emotional expression through text and simple spaces, while Unity makes it easier to build game mechanics by using existing systems. Since I’m not very comfortable coming up with a strong theme or story in a short amount of time, I decided to use Unity and focus more on mechanics and interaction instead.

<img src="../Images/week2-image1.png"
     style="border:1px solid #444; padding:4px;"
     width="500">
<img src="../Images/week2-image2.png"
     style="border:1px solid #444; padding:4px;"
     width="500">

Because of the time limit, I intentionally kept the controls very simple and limited the game to a single button for jumping. I also decided not to design handcrafted levels. Instead, I chose an endless, procedurally generated structure. This helped reduce the amount of content I needed to make and allowed me to spend more time testing whether the core gameplay idea worked.

![Game Screenshot](../Images/Week2-gif.gif)


During early testing, I expected the game to be easy to learn. However, I quickly noticed that the jump was hard to judge because of the current values (jump force, max distance, min distance etc..), which made the game much more difficult than I had planned. This showed that even in a very small and seemingly simple game, things like number tuning and difficulty curves have a big impact on how the game feels to play.

If I were to continue working on this prototype, I would first focus on adjusting the jump values to see if that makes the game easier to master for beginners. I would also want to observe how these changes affect the overall difficulty.
___
## January 22-29 – Week 2 Design Journal - Exploration Prototype 1
This week, my work focused on exploring and modifying the example project Gotta Catcha Mall, rather than starting a new game from scratch. Since the Tiny Game from the previous week was already completed, I treated this prototype as a way to better understand how an existing game works and how small changes to its rules and values can significantly affect how the game feels to play.

### Exploration
My main goal this week was to see how difficulty can be shaped through timing and pacing rather than by adding more mechanics. I wanted to explore how changing the speed at which objects are generated would affect the overall pace of the game in a very simple structure.
Instead of making the game more complex, I focused on modifying a single system and observing how that change altered the feel of the game.

### What I Modified
The main modification I made was to the spawn system. Originally, buildings were generated at a fixed interval. I changed this so that the spawn interval gradually decreases over time, meaning buildings start falling faster the longer the game runs.
I added a starting interval, a minimum interval, and a decay value so that the game becomes more intense but still has a limit. This created a simple difficulty ramp without introducing any new mechanics or rules.

<img src="../Images/week3-image2.png"
     style="border:1px solid #444; padding:4px;"
     width="500">
<img src="../Images/week3-image1.png"
     style="border:1px solid #444; padding:4px;"
     width="500">


### Observation
With a fixed spawn speed, the game felt predictable and easy to manage once the player understood the rules. After adding the decaying spawn interval, however, the experience changed noticeably.
As the game progressed and buildings began falling more frequently, I felt more pressure to make quick decisions about what to catch and what to avoid. Mistakes happened more often, because there was less time to react and reposition the basket.
As the speed increased, it became much more obvious that the game is built around choosing what to catch and what to avoid. The increasing speed made it much more obvious that the player needs to recognize which objects are worth catching and intentionally avoid others. The difficulty came from decision-making under pressure, not just from reaction speed.

### What I Learned 
This small change showed me how much impact a single numerical system can have on the overall experience. Even though the mechanics stayed exactly the same, the game felt very different once the pacing changed.
I also learned that difficulty does not need to come from adding more features. Simply adjusting timing and rhythm can create a stronger sense of tension and progression, especially in a prototype meant to test a single idea.

### What Worked
I would consider this exploration successful because it clearly demonstrated how a difficulty curve can emerge from a simple system. The prototype helped me understand how pacing influences player behavior and how quickly a game can become stressful or overwhelming when time pressure increases.

### Where I Might Go Next
If I were to continue exploring this idea, I would experiment with fine-tuning the rate at which the spawn interval decreases to find a better balance between challenge and readability. I would also be interested in testing whether clearer visual or audio feedback could help players make faster decisions as the game speeds up.
___