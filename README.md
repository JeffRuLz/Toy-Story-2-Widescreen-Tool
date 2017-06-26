# Toy Story 2 Widescreen Tool

This is a small gui program to modify the aspect ratio for the PC version of Toy Story 2: Buzz Lightyear to the Rescue.

As a bonus, it also includes two patches created by hdc0 from speedrun.com.

https://www.speedrun.com/toys2/thread/mh6ev/3#rk87

This program was only tested on my American version of the game.


# How it works

The game's aspect ratio is stored at 0xCE092 in the Toy2.exe file.
The original values were (00 00 40 3F) (float value of 3/4 in little-endian order).
The hack works by inserting your monitor's [height]/[width] float value into its place.

Some people get a "Unable to enumerate a suitable device" message box that prevents them from starting the game.
Hdc0 figured out that by changing the value at 0xAC9EB from (75 10 F6 C5 01) to (E9 18 01 00 00) fixes the problem.

He (she?) also made a patch to allow the game to use 32bit screen modes. Change the value at 0xACA44 from (74) to (EB).
See the original forum post for a better explanation.

https://www.speedrun.com/toys2/thread/mh6ev/3#rk874
