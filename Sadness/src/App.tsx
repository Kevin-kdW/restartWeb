import { useState } from 'react'
import './App.css'
import { Route, createBrowserRouter, createRoutesFromElements } from 'react-router-dom'

const router = createBrowserRouter(
  createRoutesFromElements(
    //<Route path="/" element={<RootLayout />} />
  )
)

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
    <button onClick={() => setCount((count) => count + 1)}>Click {count}</button>
    </>

  )
}

export default App
