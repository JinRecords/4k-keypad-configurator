# The 4k-keypad manual

Howdy, this is the official documentation for the 4k keypad! Please note that the project is still in its early phase, 
feedback is very much appreciated.


### Index
* [Hardware](#hardware)
* [Software](#software)
* [Troubleshooting](#troubleshooting)


### Hardware

#### Quick Start Guide

- Upon receiving the keypad, peel back the silver film located at the bottom of the keypad.
- Place the keypad firmly on a flat surface, apply pressure to the middle of the keypad to fix it in place.
- Plug in the usb cable to the keypad and to your device.
- See below for more customization!
- Enjoy!

#### Changing the LED modes

To change mode, long press and release the Middle button after 0.5 seconds (you should see all the lights flicker once).

![middle button](https://raw.githubusercontent.com/JinRecords/4k-keypad-configurator/gh-pages/docs/assets/images/middle%20button.png)

To change brightness, press and hold the middle button and tap/hold the 2 keys closest to the usb connector to change the brightness.
Release the middle key to apply the brightness.

There are 7 Light modes:

| Modes | Description | 
| :-: | ---------------------------- |
| 1 | User define colour: Hold down key(s) to change colour, release when the desired colour is chosen |
| 2 | Reactive tempo: LED changes colour base on the frequency of tapping |
| 3 | Taiko: Just taiko |
| 4 | Colour change per key: Each time a key is pressed the colour changes for that key|
| 5 | Chroma: LED cycles Through the rainbow colours|
| 6 | Trigger chroma: Key press triggers a white-to-chroma sequence |
| 7 | Invert Trigger chroma: Key press triggers a chroma-to-black sequence |


### Software

[Download](https://github.com/JinRecords/4k-keypad-configurator/releases) it if you don't have it.

#### Program the keys
- Select device (look up in Control → Hardware and Sound → Devices and Printers → 4K Keypad → properties → Hardware → COM??).
- Click "Connect".
- Key in the keys in the config input boxes. (Use ```xx``` to blank a key)

![Config input](https://raw.githubusercontent.com/JinRecords/4k-keypad-configurator/gh-pages/docs/assets/images/config%20input.png)

- Click "Flash!" when you're done.
- Do NOT unplug the keypad during the remap process.
- Watch the progress bar go brrrrr.
- you can test your keys in the text box below the progress bar.

The middle key is programmed to ```esc``` by default and cannot be changed.
For more advanced key combinations(or troubleshooting), click "console" and type 0 and enter; Follow the instructions listed there.


### Troubleshooting

Q: The sticky pad isn't sticky anymore!   
A: *Gently* peel the sticky pad from the bottom of the keypad, rinse it with clean water, let dry and place it back.

Q: The LED lights are flickering!   
A: Turn down the brightness.

Q: I still can't find the correct com port!   
A: Try unplugging and plugging in the keypad. If still can't detect brute force the com selection.

Q: The keypad is not responding/lighting up!  
A: Try a different usb port/cable or reduce the brightness.

Q: The keypad bottom came off!  
A: Apply a reasonable amount of super glue/hot glue to the back side of the bottom panel and press it back into the main enclosure.

Q: The problems aren't listed above! / I still can't solve the problem listed above!  
A: Contact the seller.


