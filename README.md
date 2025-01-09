# 1v1 Multiplayer 2D Game

## Overview

This project is a Unity-based 1v1 multiplayer 2D game designed for both mobile and PC platforms. Players can engage in real-time multiplayer battles with intuitive controls and smooth gameplay mechanics. The game supports matchmaking, player customization, and cross-platform compatibility.

## Features

- **1v1 Multiplayer Mode:** Real-time battles with online opponents.
- **Cross-Platform Play:** Compatible with Android, iOS, and PC.
- **Matchmaking System:** Quick and ranked matchmaking options.
- **Customizable Characters:** Personalize avatars with skins and accessories.
- **Responsive Controls:** Optimized for both touch and keyboard/mouse inputs.
- **Leaderboards:** Track your rank and compete globally.
- **Smooth Gameplay:** High-performance 2D physics and animations.

## Requirements

### Hardware

- **Mobile:** Android 5.0+ / iOS 11+
- **PC:** Windows 10 / macOS 10.13+
- **RAM:** 4GB+
- **Processor:** Dual-core or higher

### Software

- **Unity Version:** 2021.3 LTS or later
- **Scripting Backend:** IL2CPP recommended for mobile builds
- **Networking Solution:** Photon PUN or Unity Netcode for GameObjects (customizable)

## Getting Started

### Installation

1. Clone this repository:
   ```bash
   git clone https://github.com/yourusername/1v1-multiplayer-2d-game.git
   ```
2. Open the project in Unity (use the specified version or later).
3. Configure your network settings (Photon App ID or Netcode settings).
4. Build and run on your preferred platform.

### Running the Game

1. In Unity, open the scene `MainMenu` from the `Assets/Scenes/` folder.
2. Press **Play** to test in the Unity Editor.
3. For mobile builds, connect a device and follow Unity's build-and-run workflow.

## Controls

### Mobile:

- **Tap/Swipe:** Action-based gestures depending on the game mechanics.
- **On-screen Buttons:** Movement and attack controls.

### PC:

- **WASD/Arrow Keys:** Move the character.
- **Mouse/Spacebar:** Perform attacks or interact.

## Project Structure

```
/Assets
  /Scenes
    - MainMenu.unity
    - GamePlay.unity
  /Scripts
    - PlayerController.cs
    - NetworkManager.cs
  /Prefabs
    - Player.prefab
    - GameObjects.prefab
  /UI
    - HUD.prefab
    - MainMenuUI.prefab
```

## Networking

This project uses **Photon PUN** for matchmaking and real-time gameplay. To configure:

1. Create a Photon account at [Photon Engine](https://www.photonengine.com/).
2. Retrieve your App ID and add it to `PhotonServerSettings` in Unity.
3. Modify the `NetworkManager.cs` script if using a custom matchmaking logic.

## Contribution

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. Commit your changes and push to the branch.
4. Submit a pull request.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

## Contact

For queries or issues, feel free to open an issue or contact the developer:

- **Email:** [postariyaavinash@gmail.com](mailto\:postariyaavinash@gmail.com)
- **GitHub:** AvinashHero

