# Flappy-Birb
This is a clone of the popular game Flappy Bird, developed as a part of a tutorial to learn Unity. The game features a bird navigating through obstacles, inspired by the original Flappy Bird mechanics.

## Description
I worked on this project by following a tutorial to learn the basics of Unity game development. The primary goal was to understand the fundamentals of Unity, including physics, sprite rendering, and scripting. This project helped me gain hands-on experience with the Unity engine and provided a solid foundation for future game development projects.

## Features
- Simple Physics using RigidBody2D
- Simple Scripts for bird flying, collisions/triggers, spawning pipes
- Simple UI for score counting
- Game Over screen


## How to Play
- Press 'space' to make the bird fly
- Navigate through the gaps between obstacles to score points
- Avoid hitting the obstacles to keep playing

## Built With
- Unity Engine

## Getting Started
To play the game, download the executable from the `Flappy Birb` folder and run it on your computer.

## Future Work

- [x] **Add an Esc Menu**: Implement a pause menu that appears when the 'Esc' key is pressed, allowing the player to pause and resume the game.
- [ ] **Add Title Screen**: Develop a separate scene for the game’s title screen, including options to start the game, view instructions, and exit.
- [ ] **Add Exit Button**: Include an exit button in the Title Screen that closes the game after prompting the player for confirmation.
- [ ] **Implement Game Over Condition**: Ensure the game ends if the bird flies off the screen.
- [ ] **Prevent Score Increase After Game Over**: Make sure the score does not continue to increase after the game is over.
- [ ] **Add Sound Effects**: Integrate sound effects using the `AudioSource` component to enhance the gaming experience.
- [ ] **Create Background Clouds**: Use the Particle System to add dynamic clouds in the background for a more immersive environment.
- [ ] **Animate Bird Flapping**: Create an animation for the bird's wings to flap, making the game more visually appealing.
- [ ] **Save High Scores**: Use `PlayerPrefs` to save the player's high scores and display them in the UI.

## Credits

The initial version of this project was developed by following a tutorial by Mark Brown from Game Maker's Toolkit. You can find the tutorial on YouTube: [The Unity Tutorial For Complete Beginners](https://youtu.be/XtQMytORBmM?si=uYWYcrtZkIFHEpVL).

## Version History

### v0.1.0
- Initial release following the tutorial.
- Basic gameplay mechanics implemented:
  - Bird movement using `RigidBody2D`.
  - Collision detection.
  - Simple scoring system.
  - Game over condition.

### v0.2.0 (Planned)
- Add an Esc menu that pauses the game.
- Add a Title Screen
- Add Exit button that closes the game (prompts confirmation).
- Implement game over if the bird goes off screen.
- Ensure score can't go up after game over.

### Future Versions
- Add sound effects with `AudioSource` component.
- Make clouds in the background using the Particle System.
- Create an animation for flapping wings for the bird.
- Develop a title screen with start, instructions, and exit options.
- Save high scores using `PlayerPrefs` and display them in the UI.
