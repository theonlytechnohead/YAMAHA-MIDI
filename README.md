# YAMAHA-MIDI

GitHub repo for YAMAHA MIDI program, developed by Craig Anderson

## What is this?
The YAMAHA LS9 digital mixing console for audio is a fantastically capable device. There exists three issues with it:

1. No DCA's is a very unfortunate omission, especially considering the M7CL series has them (and released a year earlier!)
1. Input-to-Matrix is not supported ☹
1. Only one remote device can control the desk at a time (and the only mobile device that can is an iPad with StageMix)

Unfortunately, I can't easily fix 1 or 2, so instead I decided to focus my efforts on 3.  
*This program is the solution*

## How does it work?
It uses the MIDI (v1) protocol to communicate to the console, and then forwards appropriate data to the specified OSC devices
Requests received from OSC devices are also issued to the console on their behalf, as MIDI

## No really, like how does all the nitty gritty work?
See the section below on 'How did I make this happen?'

## Instructions for use:
You need:
* A USB to MIDI adapter / cable/ interface (to make the PC talk to the console)
  * Alternatively, you can attempt to use the Network MIDI driver from YAMAHA, that you would normally use for Studio Manager
* A computer
* A wireless LAN network
* Mobile device(s) with the TouchOSC app installed
* An appropriate layout file for TouchOSC
  * Conversely, you can create your own layout / app, or head to theonlytechnohead/YAMAHA-OSC and try out my WIP app

Once that's all done, follow the below steps:
1. Connect the computer and console, using the MIDI ports on the console, or the network driver if you have it working
1. Enable MIDI SysEx on the console
    1. In the DISPLAY ACCESS section, press the [SETUP] key repeatedly to access the MISC SETUP screen within the SETUP screens
    1. Move the cursor to the MIDI SETUP popup button, and press the [ENTER] key to access the MIDI SETUP popup window
    1. Ensure that 'MIDI' is selected as the port in the TX and RX fields
    1. Check that channel 1 is used for all MIDI communications in the field below the port selection
    1. Move the cursor to the TX and RX buttons, toggling each so that the 'Parameter Change' TX and RX buttons are lit, and all other TX, RX, and ECHO buttons are dark
1. Open the YAMAHA MIDI program on the computer
1. Select the appropriate MIDI ports from the 'MIDI input device' and 'MIDI outuput device' lists
1. Click 'Start MIDI' (or press the 'S' key). The app will now sync with the console
1. Click 'Add device' to open the device dialog
    1. Fill in an appropriate name for the device (all devices must be named, names do not need to be unique)
    1. Enter an available listen port (must be unique, recommended to start at 8000 and go up by 1 for each device)
    1. Enter the devices IP address (the TouchOSC app also provides this for you in it's configuration settings)
    1. Enter an available send port (must be unqie, recommended to start at 9000 and go up by 1 for each device)
    1. Click 'Add OSC device" to confirm
1. Once all the required remote devices have been added, click 'Refresh OSC' to sync them (or press the 'O' key)
1. You're done! Except... it's up to you to setup and configure the TouchOSC app or my app to work accordingly.
See https://hexler.net/products/touchosc for details on how to configure TouchOSC

## Hey, this is neat! Can you ... ?
Raise an issue if you want me to change something.
Not guaranteed for anything to happen

## I'm interested in the code, how does it work? Can I re-use it?
It's fully open-source, look all you like.
You're welcome to clone it for a closer look, but please don't redistribute this code, or any modified code (except as a pull request to this repository)
If you really like it and want to do more with it, go make your own project! Use this as the functional example I didn't have, and go make something cool!
That's not a legal licence, but also it's not like I can stop you anyway

## How did I make this happen?
Get ready for a story... soon.

## I can make this so much better
Please make a pull request when you do, otherwise suggestions via the 'Issues' tab are appreciated