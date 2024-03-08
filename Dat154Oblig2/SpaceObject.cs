﻿using System;
using System.Collections.Generic;

namespace SpaceSim
{
    public class SpaceObject
    {
        public String Name { get; set; }
        public double OrbitalRadius { get; set; }

        public double OrbitalPeriod { get; set; }

        public SpaceObject(String name, double orbitalRadius, double orbitalPeriod)
        {
            this.Name = name;
            this.OrbitalRadius = orbitalRadius;
            this.OrbitalPeriod = orbitalPeriod;
        }

        public virtual void Draw()
        {
            Console.WriteLine(Name);
        }

        public double CalculateXPosition(double time)
        {
            double angle = 2 * Math.PI * time / OrbitalPeriod;
            return OrbitalRadius * Math.Cos(angle);
        }

        public double CalculateYPosition(double time)
        {
            double angle = 2 * Math.PI * time / OrbitalPeriod;
            return OrbitalRadius * Math.Sin(angle);
        }
    }

    public class Star : SpaceObject
    {

        public Star(String name, double orbitalRadius, double orbitalPeriod) : base(name, orbitalRadius, orbitalPeriod)
        {
            
        }

        public override void Draw()
        {
            Console.Write("Star : ");
            base.Draw();
        }
    }

    public class Planet : SpaceObject
    {

        public List<Moon> Moons { get; set; }

        public Planet(String name, double orbitalRadius, double orbitalPeriod) : base(name, orbitalRadius, orbitalPeriod)
        {
            this.Moons = new List<Moon>();
        }

        public void AddMoon(Moon moon)
        {
            Moons.Add(moon);
        }

        public override void Draw()
        {
            Console.Write("Planet: ");
            base.Draw();
        }

    }

    public class Moon : SpaceObject
    {
        public Planet OrbitingPlanet { get; set; }

        public Moon(String name, double orbitalRadius, double orbitalPeriod, Planet planet) : base(name, orbitalRadius, orbitalPeriod)
        {
            this.OrbitingPlanet = planet;
        }

        public override void Draw()
        {
            Console.Write("Moon : ");
            base.Draw();
        }
    }

    public class Asteroid : SpaceObject
    {
        public Asteroid(String name, double orbitalRadius, double orbitalPeriod) : base(name, orbitalRadius, orbitalPeriod)
        {

        }
        public override void Draw()
        {
            Console.Write("Asteroid : ");
            base.Draw();
        }
    }

    public class Comet : SpaceObject
    {

        public Comet(String name, double orbitalRadius, double orbitalPeriod) : base(name, orbitalRadius, orbitalPeriod)
        {

        }

        public override void Draw()
        {
            Console.Write("Comet : ");
            base.Draw();
        }
    }

    public class AsteroidBelt : SpaceObject
    {
        public List<Asteroid> Asteroids { get; set; }

        public AsteroidBelt(String name, double orbitalRadius, double orbitalPeriod) : base(name, orbitalRadius, orbitalPeriod)
        {
            Asteroids = new List<Asteroid>();
        }

        public override void Draw()
        {
            Console.Write("AsteroidBelt : ");
            base.Draw();
        }
    }

    public class DwarfPlanet : SpaceObject
    {
        public DwarfPlanet(String name, double orbitalRadius, double orbitalPeriod) : base(name, orbitalRadius, orbitalPeriod)
        {

        }

        public override void Draw()
        {
            Console.Write("DwarfPlanet :");
            base.Draw();
        }
    }
}
