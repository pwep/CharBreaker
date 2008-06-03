This was a first cut at the CharBreaker using Java. The caret position in a text box can be found - both in terms of its character-based location ( getDot() ) and in pixel coords ( getX(), getY() ). Results are println-ed to the System.out, so start form a command line to see some numbers.

I was moving the caret programatically, and had set up a caretListener, but the caret was not reporting the correct pixel coords. Might work if a separate thread is used which uses a Java Robot to step through the textbox.

In any case, the windows-based solution is likely to be more accurate, as font rendering differs quite a bit between platforms.

Peter Phillips - 03/06/2008