// Program.cs
using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    var plantDocumentary = new Video(
      "The Secret Life of Plants",
      "Nature Channel",
      375
    );
    plantDocumentary.AddComment(new Comment("Alice",   "I never knew plants could communicate!"));
    plantDocumentary.AddComment(new Comment("Bob",     "Fascinating insights into botanical life cycles."));
    plantDocumentary.AddComment(new Comment("Charlie", "Makes me want to start a garden."));

    var quantumCats = new Video(
      "Quantum Cats",
      "Dr. Feynman",
      510
    );
    quantumCats.AddComment(new Comment("Diana",  "Quantum superposition explained so well!"));
    quantumCats.AddComment(new Comment("Edward", "Meows and particles, what a combo."));
    quantumCats.AddComment(new Comment("Fiona",  "Mind-blowing cat experiments."));

    var iceCreamDoc = new Video(
      "History of Ice Cream",
      "Sweet Talks",
      420
    );
    iceCreamDoc.AddComment(new Comment("George", "Love the variety of flavors covered."));
    iceCreamDoc.AddComment(new Comment("Hannah", "Now I want ice cream at 10am."));
    iceCreamDoc.AddComment(new Comment("Ian",    "Great for dessert enthusiasts."));

    var oceanMysteries = new Video(
      "Mysteries of the Ocean Depths",
      "Deep Dive",
      600
    );
    oceanMysteries.AddComment(new Comment("Julia", "The bioluminescent creatures are eerie!"));
    oceanMysteries.AddComment(new Comment("Alice", "Amazing underwater photography."));
    oceanMysteries.AddComment(new Comment("Bob",   "I learned so much about deep-sea vents."));

    var videos = new List<Video>
    {
      plantDocumentary,
      quantumCats,
      iceCreamDoc,
      oceanMysteries
    };

    foreach (var vid in videos)
    {
      vid.DisplayVideoDetails();
    }
  }
}
