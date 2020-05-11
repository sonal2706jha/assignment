import React, { Component } from 'react';

import Persons from './containers/Persons';

class App extends Component {
  render() {
    return (
      <div className="App">
        <ol>
          <li>This app donot have local state but instead uses Redux</li>
        </ol>
        <Persons />
      </div>
    );
  }
}

export default App;
