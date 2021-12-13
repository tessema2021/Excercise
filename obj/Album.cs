using System;
using System.Collections.Generic;


namespace lighting_excrcise
{



    public string Name { get; set; }

    private bool _downloaded;

    public void play()
    {
        if (_downloaded == true)
        {
            return Console.WriteLine($"album is playing");
        }
        else
        {
            Console.WriteLine("downloaded first before playing");
        }
    }
}


// Lightning Exercise:
// Create a new console app
// In that app, create a new class called "Album"
// Create a Property called Name that is gettable and settable
// create a field on the Album class called "_downloaded" of type bool
// create a method on the Album class called Play. If the album is downloaded, write to the console that the album is playing, 
// otherwise write to the console that the album must be downloaded first before playing