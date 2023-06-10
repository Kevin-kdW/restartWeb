import React from "react";
import { NavLink } from "react-router-dom";

export default function RootLayout() {
  return (
    <div className="rootLayout">
      RootLayout
      <header>
        <nav>
          <h1>Router</h1>
          <NavLink to="/">Home</NavLink>
          <NavLink to="about">About</NavLink>
          <NavLink to="contact">Contact</NavLink>
        </nav>
      </header>
    </div>
  );
}
