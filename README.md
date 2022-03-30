# Pong-Game-on-an-STM32

Game made with @Tartoo during our bachelor year 2 (2021/2022) for an IOT course at Ynov.

## Summary

```
- ### I. Présentation
- ### II. Unity part
    - A. How to open the project
    - B. How to build the project
    - C. How to Play the project
    - D. Problems solving
- ### III. STM32 part

    - A. Aaa
```

## I. Presentation

Project realized during an IOT course in second year at Ynov.

The project includes:

- The source code which is on the STM32 card which allows to recover the values of the joysticks.
- A mini Pong game made with unity3D compatible with joysticks.
- An explanation of how to mount on the STM32 card and how to configure the serial output to retrieve information from the joysticks

In our project a script allows unity to retrieve the hexadecimal values of our joysticks returned by the STM32.

## II. Unity part

### How to open the project:

- Clone the git repository to your computer with the following command :

```
git@github.com:LeoSery/Pong-Game-on-an-STM32.git
```

- open Unity Hub and do "_Add project from disk_"

  Select "`..\Pong-Game-on-an-STM32\PongGame`"

- Check that the project opens with the Unity editor in version "**2020.3.28f1**"

## How to build the project :

- Once the project is open in Unity, do _"File" > "Build Settings"_

- In the window that has just appeared, in the _"Scenes In Build"_ section, make sure that _"scenes/Game"_ is checked.

- for the platform choose: _"PC, Mac & Linux Standalone"_

- then choose your platform in _"Target Platform"_

- and finally press _"Build And Run"_

## Problems solving :

The project uses different optional Unity packages.
If you have an error concerning a package go to: **_"Window > Package Manager"_** and check that you have the following packages installed:

```
- 2D Pixel Perfect (4.0.1)
- 2D SpriteShape (5.2.0)
- 2D Sprite (1.0.0)
- Text Mesh Pro (3.0.6)
- Unity UI (1.0.0)
```

## III. Stm32 part :

## CubeMx configuration :

First of all, when you arrive on Stm32 CubeMx, you will need to chose the card wich you use. Then, you have to congifure it in a way where we can play with 2 joysticks.
![](https://i.imgur.com/vHWqQ6k.jpg)

To do that, you have to add 2 analogs and usart and configure them like this :
![](https://i.imgur.com/dxWpumM.png)
For the ADC :
![](https://i.imgur.com/jdwDvrc.png)
![](https://i.imgur.com/kCVXps9.png)
![](https://i.imgur.com/nbDRKus.png)

Do the same for the second ADC but be carefull to use differents pin each time !

For the usart you will have to do this :
![](https://i.imgur.com/1QW4QvE.png)

## Joystick connection :

When the configuration is done, you have to connect joysitcks to the board.
![](https://i.imgur.com/yjmbS6K.jpg)
Grnd must be plugged in ground, 5V in 3V, VRx in PA1 for the 1st joystick and VRy in PB0 again for the first joystick.

When it's done it should look like this :
![](https://i.imgur.com/6YMyuHN.jpg)
![](https://i.imgur.com/8RNmc1P.jpg)

## Systeme Workbench :

After you have done this, you will have to generate a code on systeme workbench with those parameters :
![](https://i.imgur.com/Mnx9rHf.png)

In SystemeWorkbench you will have to create your code inside the infinite loop : ![](https://i.imgur.com/KQaUTFe.png)
This code get the position of the joystick in hexadecimals and stock them in 2 value for each joystick. Then, it display them on putty so we can know the values when the joystick is up or down : 00 & FF.

The result look like this : vidéo
