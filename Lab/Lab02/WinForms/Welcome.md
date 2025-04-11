# Programming in Graphical Environment
 ## Laboratory 5 - Windows Froms - Potion Master
 
 
 ### Task description
 Your task is to create a base functionality for a Potion Master game - where you can become a wizard that is pouring parts of the mixtures between vials. The goal of the game is to separate the different colors of the mixtures into sparate vials.
 The start application in the laboratory part consists of 3 vials filled with variable filling ratio, with random colors and 1 empty vial. Apart from the game view, the application contains menu strip.
 
 ### Layout
 - Main Window:
    - Size: 800x500 px, Minimum Size: 500x300 px
    - Starting location: Center of the screen
    - Title Bar: "Potion Master"
    - Menu strip:
        - "File" menu item - contains 3 tool strip menu items: "New Game", "Surrender" and "Exit Game"
        - "Settings" menu item - contains 1 tool strip menu item: "Open Settings..."
    - Main Game area:
        - Evenly divided area into 4 parts, each containing **custom** control representing vial:
            - The vial contols cannot be resized.
            - The vial controls have to be positioned in the center of the panel/cell they are stored in.
            - The vials have to be positioned correctly when resizing the window
 
 ### Vial Control
 - Derived from UserControl class.
 - Have properties (editable from Properties Window in Main Window Designer):
    - `MaxSegments` - vial partition number, represention how many liquid parts are able to fit in the vial. 
    - `InitSegmentCount` - initial number of segmentes filled in the vial. 
    - `Segments` - collection of color segments in the vial. If set, the `InitSegmentCount` parameter is ignored.
- Have custom painting method:
    - Represented by the long vertical rectangle divided to `MaxSegments` parts.
    - Each part is represented by color liquid part.
- Can be dragged and droped onto another vial to pour the liquid:
    - Liquid can be poured onto the liquid segment with the same color (if there is enough space in another vial) or into empty vial
    - Each time the liquid is poured, the maximum number of parts in the same color is poured (cannot pour part of the liquid).

 
 ### Hints
 - OnPaint, DrawRectangle, SolidBrush, FillRectangle
 - MouseDown Event, DragEnter Event, DragDrop Event 
 - MenuStrip, Resize Event
 
 ### Grading
 - Main Window Layout (title, menu, min size, proper panels sizing - can be shown by coloring each panel): 2 pts
 - Custom UserControl drawing: 1 pt
 - Vial Control proper positioning: 1 pt
 - Vial Control properties in Designer: 1 pt
 - Pouring liquid from one vial to another: 2 pts
 - Pouring always maximum number of liquid parts: 1 pt